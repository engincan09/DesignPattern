using DesignPattern.CreationalPatterns.Builder;
using DesignPattern.CreationalPatterns.Prototype;
using DesignPattern.Structural.Adapter;
using DesignPattern.Structural.Bridge;
using KodOrnek.CreationalPatterns.AbstractFactory;
using KodOrnek.CreationalPatterns.Factory;
using KodOrnek.Singleton;
using System;

namespace KodOrnek
{
    class Program
    {
        static void Main(string[] args)
        {

       
            Message textMessage = new TextMessage(new TextMessageSender());
            textMessage.Send();

            
            Message emailMessage = new EmailMessage(new EmailMessageSender());
            emailMessage.Send(); 
        }
    }
}
