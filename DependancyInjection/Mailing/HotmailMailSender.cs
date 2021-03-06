﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependancyInjection
{
    public class HotmailMailSender : IMailSender
    {
        private readonly ILogging logging;

        public HotmailMailSender(ILogging logging)
        {            
            // when instantiating this class, Ninject will automatically resolve which implementation of ILogging to use and pass it in
            this.logging = logging;
        }

        public void Send(string toAddress, string subject)
        {
            logging.Debug("Sending Hotmail mail");
            Console.WriteLine("Sending Hotmail mail to [{0}] with subject [{1}]", toAddress, subject);
        }
    }
}
