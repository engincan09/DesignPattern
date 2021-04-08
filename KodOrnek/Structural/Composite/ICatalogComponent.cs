using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Composite
{
    //Soyut sınıfımız
    //İstemci sınıf bu yapıyı uygular.
    // UML diyagramındaki Component kısmına denk gelmektedir
    public interface ICatalogComponent
    {
        void Hierarchy();
    }
}
