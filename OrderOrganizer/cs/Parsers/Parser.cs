using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderOrganizer
{
    public abstract class Parser
    {
        public abstract IEnumerable<Order> GetParsedOrders();
        public string GetNameOfInputFile(string pathToFile)
        {
            return pathToFile.Substring(pathToFile.LastIndexOf('\\') + 1);
        }
    }
}
