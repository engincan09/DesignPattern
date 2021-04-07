using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility
{
    // JPG dosyalarını dönüştüren sınıf.
    // UML diyagramındaki ConcreteHandler sınıfına denk gelmektedir.
    public class JPEGHandler : BaseHandler
    {
        public override void HandleRequest(Image image)
        {
            if (image.Extension == "JPEG")
            {
                Console.WriteLine("JPEG to PNG");
                //JPEG Dönüştürme işlemleri
            }
            else
            {
                //Bu sınıfa ait bir işlem değilse zincirin bir sonraki halkasına aktarılır
                _nextHandler.HandleRequest(image);
            }
        }
    }
}
