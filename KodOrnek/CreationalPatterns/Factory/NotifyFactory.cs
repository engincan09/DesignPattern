using System;
using System.Collections.Generic;
using System.Text;

namespace KodOrnek.CreationalPatterns.Factory
{
    // UML diyagramındaki ProductFactory sınıfına denk gelmektedir.
    public class NotifyFactory
    {
        public INotifyService Create(string notifyType)
        {
            if (notifyType == "sms")
            {
                return new SmsManager();
            }
            else if (notifyType == "mail")
            {
                return new MailManager();
            }
            return null;
        }
    }
}
