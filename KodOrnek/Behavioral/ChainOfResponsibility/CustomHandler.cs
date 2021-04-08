﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility
{
    // Herhangi bir tipteki dosyayı dönüştüren sınıf.
    // UML diyagramındaki ConcreteHandler sınıfına denk gelmektedir.
    class CustomHandler : BaseHandler
    {
        public override void HandleRequest(Image image)
        {
            if (image.Extension == "OtherExtension")
            {
                Console.WriteLine("OtherExtension to PNG");
                // Herhangi bir tipteki dosyanın işlemine ait dönüştürme kodları işlemleri.
            }
            // Burada else ifadesi bulunmamaktadır bu da zincirin son halkası olduğu anlamına gelir.
        }
    }
}
