using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependancyInjection
{
    public class DbLogging : ILogging
    {
        public void Debug(string message)
        {
            Console.WriteLine("DB Logging: [{0}]", message);
        }
    }
}
