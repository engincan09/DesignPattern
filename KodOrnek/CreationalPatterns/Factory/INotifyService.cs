using System;
using System.Collections.Generic;
using System.Text;

namespace KodOrnek.CreationalPatterns.Factory
{
    //Bütün bilgilendirme türlerinin arayüzü
    public interface INotifyService
    {
        void Send(User user);
    }
}
