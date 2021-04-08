using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility
{
    // JPG dosyalarını dönüştüren sınıf.
    // UML diyagramındaki ConcreteHandler sınıfına denk gelmektedir.
    public class JPGHandler : BaseHandler
    {
        public override void HandleRequest(Image image)
        {
            if (image.Extension == "JPG")
            {
                Console.WriteLine("JPG to PNG");
                // JPG işlemine ait dönüştürme kodları işlemleri.
            }
            else
            {
                // Bu sınıfa ait bir işlem değilse zincirin bir sonraki halkasına aktarılır.
                _nextHandler.HandleRequest(image);
            }
        }
    }
}
