using System;

namespace DependancyInjection
{
    public interface IMailSender
    {
        void Send(string toAddress, string subject);
    }
}
