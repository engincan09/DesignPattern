using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Mediator
{
    // Haberleşme için ortak bir arayüz sağlar.
    // Haberleşme Mediator tarafından gerçekleşeceği için bir örneğini tutar.
    // Mesaj alma ve mesaj gönderme özellikleri içermektedir.
    // UML diyagramındaki Colleague yapısına denk gelir.
    public abstract class User
    {
        public int id;
        public string name;
        private IChatRoomMediator _chatRoomMediator;

        public User(IChatRoomMediator chatRoomMediator)
        {
            _chatRoomMediator = chatRoomMediator;
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"{name} Yeni mesaj alındı. Mesaj:{message}");
        }
        public void SendMessage(string message, int userId)
        {
            Console.WriteLine($"{name} Mesaj Gönderildi. Kime: {userId}");
            _chatRoomMediator.sendMessage(message, userId);
        }
    }
}
