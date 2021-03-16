using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Bridge
{
    public class EmailMessageSender : IMessageSender
    {
        public void SendMessage(Message message)
        {
            Console.WriteLine("Email Message");
        }
    }
}
