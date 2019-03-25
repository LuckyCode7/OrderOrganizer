using System.Collections.Generic;
using System.Linq;

namespace OrderOrganizer.cs.Database
{
    public static class OrdersDatabaseExtensions
    {
        public static int GetNumberOfOrders(this OrdersDatabase database) =>
           database.Count();

        public static int GetNumberOfOrders(this OrdersDatabase database, string ClientID) =>
            database.Where(x => x.ClientId == ClientID).Count();

        public static double GetTotalAmountOfOrders(this OrdersDatabase database) => 
            database.Sum(x => x.Price);

        public static double GetTotalAmountOfOrders(this OrdersDatabase database, string ClientID) =>
            database.Where(x => x.ClientId == ClientID).Sum(x => x.Price);

        public static double GetAverageAmountOfOrders(this OrdersDatabase database) =>
            database.Average(x => x.Price);

        public static double GetAverageAmountOfOrders(this OrdersDatabase database, string ClientID) =>
            database.Where(x => x.ClientId == ClientID).Average(x => x.Price);

        public static int GetNumberOfOrdersGroupedByName(this OrdersDatabase database) =>
            database.GroupBy(x => x.Name).Count();

        public static int GetNumberOfOrdersGroupedByName(this OrdersDatabase database, string ClientID) =>
            database.Where(x => x.ClientId == ClientID).GroupBy(x => x.Name).Count();

        public static IEnumerable<Order> GetDatabaseSortedByClientID(this OrdersDatabase database) =>
            database.OrderBy(x => x.ClientId);

        public static IEnumerable<Order> GetDatabaseSortedByClientID(this IEnumerable<Order> database) =>
            database.OrderBy(x => x.ClientId);

        public static IEnumerable<Order> GetDatabaseSortedByClientID(this OrdersDatabase database, string ClientID) =>
            database.Where(x => x.ClientId == ClientID).OrderBy(x => x.ClientId);

        public static IEnumerable<Order> GetDatabaseSortedByClientID(this IEnumerable<Order> database, string ClientID) =>
            database.Where(x => x.ClientId == ClientID).OrderBy(x => x.ClientId);

        public static IEnumerable<Order> GetDatabaseSortedByRequestID(this OrdersDatabase database) =>
            database.OrderBy(x => x.RequestId);

        public static IEnumerable<Order> GetDatabaseSortedByRequestID(this IEnumerable<Order> database) =>
            database.OrderBy(x => x.RequestId);

        public static IEnumerable<Order> GetDatabaseSortedByRequestID(this OrdersDatabase database, string ClientID) =>
            database.Where(x => x.ClientId == ClientID).OrderBy(x => x.RequestId);

        public static IEnumerable<Order> GetDatabaseSortedByRequestID(this IEnumerable<Order> database, string ClientID) =>
            database.Where(x => x.ClientId == ClientID).OrderBy(x => x.RequestId);

        public static IEnumerable<Order> GetDatabaseSortedByName(this OrdersDatabase database) =>
            database.OrderBy(x => x.Name);

        public static IEnumerable<Order> GetDatabaseSortedByName(this IEnumerable<Order> database) =>
            database.OrderBy(x => x.Name);

        public static IEnumerable<Order> GetDatabaseSortedByName(this OrdersDatabase database, string ClientID) =>
            database.Where(x => x.ClientId == ClientID).OrderBy(x => x.Name);

        public static IEnumerable<Order> GetDatabaseSortedByName(this IEnumerable<Order> database, string ClientID) =>
            database.Where(x => x.ClientId == ClientID).OrderBy(x => x.Name);

        public static IEnumerable<Order> GetDatabaseSortedByQuantity(this OrdersDatabase database) =>
            database.OrderBy(x => x.Quantity);

        public static IEnumerable<Order> GetDatabaseSortedByQuantity(this IEnumerable<Order> database) =>
            database.OrderBy(x => x.Quantity);

        public static IEnumerable<Order> GetDatabaseSortedByQuantity(this OrdersDatabase database, string ClientID) =>
            database.Where(x => x.ClientId == ClientID).OrderBy(x => x.Quantity);

        public static IEnumerable<Order> GetDatabaseSortedByQuantity(this IEnumerable<Order> database, string ClientID) =>
            database.Where(x => x.ClientId == ClientID).OrderBy(x => x.Quantity);

        public static IEnumerable<Order> GetDatabaseSortedByPrice(this OrdersDatabase database) =>
            database.OrderBy(x => x.Price);

        public static IEnumerable<Order> GetDatabaseSortedByPrice(this IEnumerable<Order> database) =>
            database.OrderBy(x => x.Price);

        public static IEnumerable<Order> GetDatabaseSortedByPrice(this OrdersDatabase database, string ClientID) =>
            database.Where(x => x.ClientId == ClientID).OrderBy(x => x.Price);

        public static IEnumerable<Order> GetDatabaseSortedByPrice(this IEnumerable<Order> database, string ClientID) =>
            database.Where(x => x.ClientId == ClientID).OrderBy(x => x.Price);

        public static IEnumerable<Order> GetDatabaseFromPriceRange(this OrdersDatabase database, double from, double to) =>
            database.Where(x => x.Price >= from && x.Price <= to);

        public static IEnumerable<Order> GetDatabaseFromPriceRange(this OrdersDatabase database, string ClientID, double from, double to) =>
            database.Where(x => x.ClientId == ClientID).Where(x => x.Price >= from && x.Price <= to);

        public static bool CheckClientByClientId(this OrdersDatabase database, string clientId)
        {
            foreach (var order in database)
            {
                if (order.ClientId == clientId)
                    return true;
            }
            return false;
        }
    }
}
