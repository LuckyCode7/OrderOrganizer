using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace OrderOrganizer
{
    public class XMLParser : Parser
    {
        private readonly string pathToFile;

        public XMLParser(string pathToFile_) => pathToFile = pathToFile_;

        public override IEnumerable<Order> GetParsedOrders()
        {
            return XDocument.Load(pathToFile)
                .Root.Elements("request")
                .Select(Parse);
        }

        private string GetInvalidOrderAsString(XElement request)
        {
            return
                GetNameOfInputFile(pathToFile) + ": "
                    + request.Element("clientId")?.Value + " "
                    + request.Element("requestId")?.Value + " "
                    + request.Element("name")?.Value + " "
                    + request.Element("quantity")?.Value + " "
                    + request.Element("price")?.Value;
        }

        private Order Parse(XElement request)
        {
            var order = new Order();
            if (OrderValidator.TrySetClientID(request.Element("clientId")?.Value, out order.ClientId) &&
               OrderValidator.TrySetRequestID(request.Element("requestId")?.Value, out order.RequestId) &&
               OrderValidator.TrySetName(request.Element("name")?.Value, out order.Name) &&
               OrderValidator.TrySetQuantityID(request.Element("quantity")?.Value, out order.Quantity) &&
               OrderValidator.TrySetPrice(request.Element("price")?.Value, out order.Price))
                return order;
            else
            {
                order.IsCorrect = false;
                order.AsString = GetInvalidOrderAsString(request);
                return order;
            }
        }
    }
}
