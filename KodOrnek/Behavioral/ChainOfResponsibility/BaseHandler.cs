using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility
{
    //Zincirin bir sonraki halkasının referansını tutulduğu yerdir
    //İşlemi gerçekleştirecek olan metot tanımı bulunudr.
    //UML diyagramında BaseHandler sınıfında denk gelmektedir.
    public abstract class BaseHandler 
    {
        protected BaseHandler _nextHandler;
        public void SetNextHandler(BaseHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }
        public abstract void HandleRequest(Image image);
    }
}
