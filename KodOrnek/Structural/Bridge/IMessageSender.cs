using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Bridge
{
    // Abstraction (Message) tarafından referansı tutulur 
    //ve haberleşme burası ile gerçekleşir
    public interface IMessageSender
    {
        void SendMessage(Message message);
    }
}
