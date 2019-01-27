using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependancyInjection
{
    public class FileLogging : ILogging 
    {
        public void Debug(string message)
        {
            Console.WriteLine("File Logging: [{0}]", message);
        }
    }
}
