using System.Collections;
using System.Collections.Generic;

namespace OrderOrganizer
{
    public class OrdersDatabase : IEnumerable<Order>
    {
        private List<Order> Orders;
        public List<string> InvalidOrders { get; private set; }

        public OrdersDatabase()
        {
            Orders = new List<Order>();
            InvalidOrders = new List<string>();
        }

        public void AddOrdersFromExternalFile(Parser parser)
        {
            foreach (var order in parser.GetParsedOrders())
            {
                if (order.IsCorrect)
                    Orders.Add(order);
                else InvalidOrders.Add(order.AsString);
            }
        }

        public void Clear()
        {
            Orders.Clear();
            InvalidOrders.Clear();
        }

        public IEnumerator<Order> GetEnumerator() => Orders.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public bool IsEmpty() => (Orders.Count == 0);
    }
}
