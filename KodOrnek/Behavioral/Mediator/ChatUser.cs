using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Mediator
{
    // Colleague (User) soyutundan türer.
    // Mediator sayesinde diğer sınıf örnekler ile iletişim kurar.
    // UML diyagramındaki ConcreteColleague yapısına denk gelmektedir.
    public class ChatUser : User
    {
        public ChatUser(IChatRoomMediator chatRoomMediator) : base(chatRoomMediator)
        {
        }
    }
}
