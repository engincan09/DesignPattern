using System;
using System.Collections.Generic;
using System.Text;

namespace KodOrnek.CreationalPatterns.Factory
{
    //Bütün bilgilendirme türlerinin arayüzü
    //UML diyagramındaki IProduct arayüzümüze denk gelmektedir.
    public interface INotifyService
    {
        void Send(User user);
    }
}
