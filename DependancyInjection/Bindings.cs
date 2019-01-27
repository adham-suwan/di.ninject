using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Modules;

namespace DependancyInjection
{
    public class Bindings : NinjectModule // the name of the class can be whatever you like; Ninject will find it as long as it inherits from NinjectModule
    {
        public override void Load()
        {
            // configure IMailSender and ILogging to resolve to their specified concrete implementations
            Bind<IMailSender>().To<HotmailMailSender>();
            Bind<ILogging>().To<FileLogging>(); 
            Bind<IFormHandler>().To<FormHandler>();
        }
    }
}
