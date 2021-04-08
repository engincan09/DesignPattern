using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Decorator
{
    //Üst sınıfların uygulayacağı arayüz
    //Yapılacak olan temel işlemlerin imzası
    // UML diyagramındaki Component arayüzüne denk gelmektedir.
    public interface IDataSource
    {
        string GetFileName();
        void WriteData(object data);
        void ReadData();
    }
}
