using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Bridge
{
    // UML diyagramındaki RefinedAbstraction kısmına denk gelmektedir.
    public class EmailMessage : Message
    {
        public EmailMessage(IMessageSender messageSender) : base(messageSender)
        {

        }
        public override void Send()
        {
            _messageSender.SendMessage(this);
        }
    }
}
