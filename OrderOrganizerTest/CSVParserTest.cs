using OrderOrganizer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using System.Linq;

namespace OrderValidatorTest
{
    [TestClass]
    public class CSVParserTest
    {
        private static string WorkingDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        CSVParser parser = new CSVParser(WorkingDirectory + "/TestFile/TestFileCSV.csv");

        [TestMethod]
        public void CheckGetParsedOrders()
        {
            var ParsedFiles = parser.GetParsedOrders();
            Assert.AreEqual(ParsedFiles.Count(), 7);
        }

        [TestMethod]
        public void CheckGetNameOfInputFile()
        {
            string FileName = parser.GetNameOfInputFile(WorkingDirectory + @"\TestFile\TestFileCSV.csv");
            Assert.AreEqual("TestFileCSV.csv", FileName);
        }
    }
}
