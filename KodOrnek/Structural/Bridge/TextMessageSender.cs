using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Bridge
{
    public class TextMessageSender : IMessageSender
    {
        public void SendMessage(Message message)
        {
            Console.WriteLine("Text Message");
        }
    }
}
