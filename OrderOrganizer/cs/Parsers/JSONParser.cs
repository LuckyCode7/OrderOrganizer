using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace OrderOrganizer
{
    public class JSONParser : Parser
    {
        private readonly string pathToFile;
 
        public JSONParser(string pathToFile_) => pathToFile = pathToFile_;

        public override IEnumerable<Order> GetParsedOrders()
        {        
            dynamic dynJson = JsonConvert.DeserializeObject(File.ReadAllText(pathToFile));
            foreach (var order in dynJson.requests)
            {
                Order Order = new Order();
                if (OrderValidator.TrySetClientID(Convert.ToString(order.clientId), out Order.ClientId) &&
                    OrderValidator.TrySetRequestID(Convert.ToString(order.requestId), out Order.RequestId) &&
                    OrderValidator.TrySetName(Convert.ToString(order.name), out Order.Name) &&
                    OrderValidator.TrySetQuantityID(Convert.ToString(order.quantity), out Order.Quantity) &&
                    OrderValidator.TrySetPrice(Convert.ToString(order.price), out Order.Price))
                    yield return Order;
                else
                {
                    Order.IsCorrect = false;
                    Order.AsString = GetInvalidOrderAsString(order);
                    yield return Order;
                }
            }
        }

        private string GetInvalidOrderAsString(dynamic order)
        {
            return
                GetNameOfInputFile(pathToFile) + ": "
                + Convert.ToString(order.clientId) + " "
                + Convert.ToString(order.requestId) + " "
                + Convert.ToString(order.name) + " "
                + Convert.ToString(order.quantity) + " "
                + Convert.ToString(order.price);
        }
    }
}

