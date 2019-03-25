using OrderOrganizer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using System.Linq;

namespace OrderValidatorTest
{
    [TestClass]
    public class XMLParserTest
    {
        private static string WorkingDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        XMLParser parser = new XMLParser(WorkingDirectory + "/TestFile/TestFileXML.xml");

        [TestMethod]
        public void CheckGetParsedOrders()
        {
            var ParsedFiles = parser.GetParsedOrders();
            Assert.AreEqual(ParsedFiles.Count(), 7);
        }

        [TestMethod]
        public void CheckGetNameOfInputFile()
        {
            string FileName = parser.GetNameOfInputFile(WorkingDirectory + @"\TestFile\TestFileXML.xml");
            Assert.AreEqual("TestFileXML.xml", FileName);
        }
    }
}
