using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility
{
    //Uygulama süresince resimleri temsil edecek sınıfımız
    public class Image
    {
        public string Name;
        public string Extension;
        public Image(string name,string extension)
        {
            Name = name;
            Extension = extension;
        }
    }
}
