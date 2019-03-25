using OrderOrganizer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using System.Linq;

namespace OrderValidatorTest
{
    [TestClass]
    public class JSONParserTest
    {
        private static string WorkingDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        JSONParser parser = new JSONParser(WorkingDirectory + "/TestFile/TestFileJSON.json");

        [TestMethod]
        public void CheckGetParsedOrders()
        {
            var ParsedFiles = parser.GetParsedOrders();
            Assert.AreEqual(ParsedFiles.Count(), 5);
        }

        [TestMethod]
        public void CheckGetNameOfInputFile()
        {
            string FileName = parser.GetNameOfInputFile(WorkingDirectory + @"\TestFile\TestFileJSON.json");
            Assert.AreEqual("TestFileJSON.json", FileName);
        }
    }
}
