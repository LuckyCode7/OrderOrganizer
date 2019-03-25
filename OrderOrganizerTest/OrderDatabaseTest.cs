using OrderOrganizer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using OrderOrganizer.cs.Database;

namespace OrderOrganizerTest
{
    [TestClass]
    public class OrderDatabaseTest
    {
        private OrdersDatabase database = new OrdersDatabase();
        private string WorkingDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;

        [TestMethod]
        public void CheckAddOrdersFromExternalFile()
        {
            database.AddOrdersFromExternalFile(new CSVParser(WorkingDirectory + "/TestFile/TestFileCSV.csv"));
            Assert.AreEqual(database.Count(), 4);
        }

        [TestMethod]
        public void CheckClearFunction()
        {
            database.AddOrdersFromExternalFile(new CSVParser(WorkingDirectory + "/TestFile/TestFileCSV.csv"));
            database.Clear();
            Assert.IsTrue(database.IsEmpty());
        }

        [TestMethod]
        public void CheckGetNumberOfOrders()
        {
            database.AddOrdersFromExternalFile(new CSVParser(WorkingDirectory + "/TestFile/TestFileCSV.csv"));
            Assert.AreEqual(database.GetNumberOfOrders(), 4);
        }

        [TestMethod]
        public void CheckGetNumberOfOrdersForClientID()
        {
            database.AddOrdersFromExternalFile(new CSVParser(WorkingDirectory + "/TestFile/TestFileCSV.csv"));
            Assert.AreEqual(database.GetNumberOfOrders("1"), 3);
        }

        [TestMethod]
        public void CheckGetTotalAmountOfOrders()
        {
            database.AddOrdersFromExternalFile(new CSVParser(WorkingDirectory + "/TestFile/TestFileCSV.csv"));
            Assert.AreEqual(database.GetTotalAmountOfOrders(), 50.00);
        }

        [TestMethod]
        public void CheckGetTotalAmountOfOrdersForClientID()
        {
            database.AddOrdersFromExternalFile(new CSVParser(WorkingDirectory + "/TestFile/TestFileCSV.csv"));
            Assert.AreEqual(database.GetTotalAmountOfOrders("1"), 40.00);
        }

        [TestMethod]
        public void CheckGetAverageAmountOfOrders()
        {
            database.AddOrdersFromExternalFile(new CSVParser(WorkingDirectory + "/TestFile/TestFileCSV.csv"));
            Assert.AreEqual(database.GetAverageAmountOfOrders(), 12.50);
        }

        [TestMethod]
        public void CheckGetAverageAmountOfOrdersForClientID()
        {
            database.AddOrdersFromExternalFile(new CSVParser(WorkingDirectory + "/TestFile/TestFileCSV.csv"));
            Assert.AreEqual(Math.Round(database.GetAverageAmountOfOrders("1"), 2), 13.33);
        }

        [TestMethod]
        public void CheckGetNumberOfOrdersGroupedByName()
        {
            database.AddOrdersFromExternalFile(new CSVParser(WorkingDirectory + "/TestFile/TestFileCSV.csv"));
            Assert.AreEqual(database.GetNumberOfOrdersGroupedByName(), 2);
        }

        [TestMethod]
        public void CheckGetNumberOfOrdersGroupedByNameForClientID()
        {
            database.AddOrdersFromExternalFile(new CSVParser(WorkingDirectory + "/TestFile/TestFileCSV.csv"));
            Assert.AreEqual(database.GetNumberOfOrdersGroupedByName("1"), 2);
        }

        [TestMethod]
        public void CheckClientByClientIdWhenClientIDExists()
        {
            database.AddOrdersFromExternalFile(new CSVParser(WorkingDirectory + "/TestFile/TestFileCSV.csv"));
            Assert.IsTrue(database.CheckClientByClientId("1"));
        }

        [TestMethod]
        public void CheckClientByClientIdWhenClientIDNotExists()
        {
            database.AddOrdersFromExternalFile(new CSVParser(WorkingDirectory + "/TestFile/TestFileCSV.csv"));
            Assert.IsFalse(database.CheckClientByClientId("33"));
        }
    }
}
