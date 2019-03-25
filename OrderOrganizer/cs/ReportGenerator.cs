using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OrderOrganizer.cs
{
    class ReportGenerator
    {
        private StringBuilder sb = new StringBuilder();
        private string ReportsName;
        private readonly string WorkingDirectory = 
            Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/Reports/";

        public ReportGenerator(string ReportsName_)
        {
            ReportsName = ReportsName_;
            Add("Generated: " + DateTime.UtcNow.ToString());
        }

        public void Add(string input)
        {
            sb.AppendLine(input);
        }

        public void Generate()
        {
            File.WriteAllText(WorkingDirectory + ReportsName + ".csv", sb.ToString());
        }

        public void Add(IEnumerable<Order> inputs)
        {
            foreach (var input in inputs)
            {
                sb.AppendLine(input.ToString());
            }
        }
    }
}