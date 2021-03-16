using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Bridge
{
    //IMessageSender arayüzünün referansını tutuyor.
    public abstract class Message
    {
        protected IMessageSender _messageSender;

        public Message(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }
        public abstract void Send();
    }
}
