using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OrderOrganizer
{
    public class CSVParser : Parser
    {
        private readonly string pathToFile;

        public CSVParser(string pathToFile_) => pathToFile = pathToFile_;

        public override IEnumerable<Order> GetParsedOrders()
        {
            return File.ReadAllLines(pathToFile)
                  .Skip(1)
                  .Where(line => line.Length > 1)
                  .Select(Parse);
        }

        private string GetInvalidOrderAsString(string[] column)
        {
            return GetNameOfInputFile(pathToFile) + ": " + column[0] + " "
                + column[1] + " " + column[2]
                + " " + column[3] + column[4];
        }

        private Order Parse(string line)
        {
            var column = line.Split(',');
            var order = new Order();
            if (OrderValidator.TrySetClientID(column[0], out order.ClientId) &&
               OrderValidator.TrySetRequestID(column[1], out order.RequestId) &&
               OrderValidator.TrySetName(column[2], out order.Name) &&
               OrderValidator.TrySetQuantityID(column[3], out order.Quantity) &&
               OrderValidator.TrySetPrice(column[4], out order.Price))
                return order;
            else
            {
                order.IsCorrect = false;
                order.AsString = GetInvalidOrderAsString(column);
                return order;
            }
        }
    }
}
