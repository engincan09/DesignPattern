using System;
using System.Collections.Generic;
using System.Text;

namespace KodOrnek.CreationalPatterns.Factory
{
    // UML diyagramındaki ConcreteProduct sınıflarına denk gelmektedir.
    public class MailManager : INotifyService
    {
        public void Send(User user)
        {
            Console.WriteLine("Mail gönderildi.");
        }
    }
}
