using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Bridge
{
    public class TextMessage : Message
    {
        public TextMessage(IMessageSender messageSender):base(messageSender)
        {

        }
        public override void Send()
        {
            _messageSender.SendMessage(this);
        }
    }
}
