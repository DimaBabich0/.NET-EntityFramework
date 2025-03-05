using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public class Logger
    {
        static readonly string filePath = "Log.txt";

        public void LogAdded(string name, string surname)
        {
            string message = $"Added employee: {name} {surname}";
            LogToFile(message);
        }

        public void LogDeleted(string name, string surname)
        {
            string message = $"Deleted employee: {name} {surname}";
            LogToFile(message);
        }

        public void LogSearched(string criteria, string input)
        {
            string message = $"Searched by {criteria}: {input}";
            LogToFile(message);
        }

        private void LogToFile(string message)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(message);
            }
        }
    }
}
