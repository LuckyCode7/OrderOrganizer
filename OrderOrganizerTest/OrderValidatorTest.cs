using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderOrganizer;

namespace OrderOrganizerTest
{
    [TestClass]
    public class OrderValidatorTest
    {
        [TestMethod]
        public void TrySetClientID_onlyNumbers()
        {
            string TestString = null;
            bool state = OrderValidator.TrySetClientID("123456", out TestString);
            Assert.IsTrue(state);
            Assert.AreEqual(TestString, "123456");
        }

        [TestMethod]
        public void TrySetClientID_onlyLetters()
        {
            string TestString = null;
            bool state = OrderValidator.TrySetClientID("abcdef", out TestString);
            Assert.IsTrue(state);
            Assert.AreEqual(TestString, "abcdef");
        }

        [TestMethod]
        public void TrySetClientID_lettersAndNumbers()
        {
            string TestString = null;
            bool state = OrderValidator.TrySetClientID("123abc", out TestString);
            Assert.IsTrue(state);
            Assert.AreEqual(TestString, "123abc");
        }

        [TestMethod]
        public void TrySetClientID_lettersAndNumbersTooLong()
        {
            string TestString = null;
            bool state = OrderValidator.TrySetClientID("123abc4", out TestString);
            Assert.IsFalse(state);
            Assert.AreEqual(TestString, "");
        }

        [TestMethod]
        public void TrySetClientID_checkSpace()
        {
            string TestString = null;
            bool state = OrderValidator.TrySetClientID("123a o", out TestString);
            Assert.IsFalse(state);
            Assert.AreEqual(TestString, "");
        }

        [TestMethod]
        public void TrySetClientID_invalidCharacter()
        {
            string TestString = null;
            bool state = OrderValidator.TrySetClientID("abc-de", out TestString);
            Assert.IsFalse(state);
            Assert.AreEqual(TestString, "");
        }

        [TestMethod]
        public void TrySetClientID_emptyString()
        {
            string TestString = null;
            bool state = OrderValidator.TrySetClientID("", out TestString);
            Assert.IsFalse(state);
            Assert.AreEqual(TestString, "");
        }

        [TestMethod]
        public void TrySetRequestID_number()
        {
            long number;
            bool state = OrderValidator.TrySetRequestID("3", out number);
            Assert.IsTrue(state);
            Assert.AreEqual(number, 3);
        }

        [TestMethod]
        public void TrySetRequestID_negativeNumber()
        {
            long number;
            bool state = OrderValidator.TrySetRequestID("-3", out number);
            Assert.IsFalse(state);
        }

        [TestMethod]
        public void TrySetRequestID_invalidCharacter()
        {
            long number;
            bool state = OrderValidator.TrySetRequestID("f", out number);
            Assert.IsFalse(state);
        }

        [TestMethod]
        public void TrySetRequestID_emptyLong()
        {
            long number;
            bool state = OrderValidator.TrySetRequestID("", out number);
            Assert.IsFalse(state);
        }

        [TestMethod]
        public void TrySetName_alphaNumeric()
        {
            string TestString = null;
            bool state = OrderValidator.TrySetName("abc134", out TestString);
            Assert.IsTrue(state);
            Assert.AreEqual(TestString, "abc134");
        }

        [TestMethod]
        public void TrySetName_invalidCharacter()
        {
            string TestString = null;
            bool state = OrderValidator.TrySetName("abc134?", out TestString);
            Assert.IsFalse(state);
            Assert.AreEqual(TestString, "");
        }

        [TestMethod]
        public void TrySetName_space()
        {
            string TestString = null;
            bool state = OrderValidator.TrySetName("ab c134", out TestString);
            Assert.IsTrue(state);
            Assert.AreEqual(TestString, "ab c134");
        }

        [TestMethod]
        public void TrySetName_emptyString()
        {
            string TestString = null;
            bool state = OrderValidator.TrySetName(" ", out TestString);
            Assert.IsFalse(state);
            Assert.AreEqual(TestString, "");
        }

        [TestMethod]
        public void TrySetQuantityID_number()
        {
            int number;
            bool state = OrderValidator.TrySetQuantityID("0", out number);
            Assert.IsTrue(state);
            Assert.AreEqual(number, 0);
        }

        [TestMethod]
        public void TrySetQuantityID_invalidCharacter()
        {
            int number;
            bool state = OrderValidator.TrySetQuantityID("x", out number);
            Assert.IsFalse(state);
        }

        [TestMethod]
        public void TrySetQuantityID_emptyString()
        {
            int number;
            bool state = OrderValidator.TrySetQuantityID(" ", out number);
            Assert.IsFalse(state);
        }

        [TestMethod]
        public void TrySetQuantityID_negativeQuantity()
        {
            int number;
            bool state = OrderValidator.TrySetQuantityID("-4", out number);
            Assert.IsFalse(state);
        }

        [TestMethod]
        public void TrySetPrice_double1()
        {
            double number;
            bool state = OrderValidator.TrySetPrice("12.00", out number);
            Assert.IsTrue(state);
            Assert.AreEqual(number, 12.00);
        }

        [TestMethod]
        public void TrySetPrice_double2()
        {
            double number;
            bool state = OrderValidator.TrySetPrice("0.01", out number);
            Assert.IsTrue(state);
            Assert.AreEqual(number, 0.01);
        }

        [TestMethod]
        public void TrySetPrice_invalidCharacter()
        {
            double number;
            bool state = OrderValidator.TrySetPrice("v", out number);
            Assert.IsFalse(state);
        }

        [TestMethod]
        public void TrySetPrice_emptyString()
        {
            double number;
            bool state = OrderValidator.TrySetPrice(" ", out number);
            Assert.IsFalse(state);
        }

        [TestMethod]
        public void TrySetPrice_ToManyPeanuts()
        {
            double number;
            bool state = OrderValidator.TrySetPrice("1.999", out number);
            Assert.IsFalse(state);
        }

        [TestMethod]
        public void TrySetPrice_NegativePrice()
        {
            double number;
            bool state = OrderValidator.TrySetPrice("-1.99", out number);
            Assert.IsFalse(state);
        }
    }
}
