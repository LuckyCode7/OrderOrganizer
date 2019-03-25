using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderOrganizer;

namespace OrderOrganizerTest
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void checkToStringMethod()
        {
            Order order = new Order()
            {
                ClientId = "1",
                RequestId = 3,
                Name = "Serek",
                Quantity = 3,
                Price = 7.60
            };

            string result = "ClientID [1] RequestID [3] Name [Serek] Quantity [3] Price [7,60]";
            Assert.AreEqual(order.ToString(), result);
        }
    }
}
