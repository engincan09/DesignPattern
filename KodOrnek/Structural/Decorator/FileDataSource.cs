using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Decorator
{
    //Temel işlemlerin kullanıldığı sınıf
    //IDataSource arayüzünün imzasını kullanır.
    public class FileDataSource : IDataSource
    {
        private string _fileName;

        public FileDataSource(string fileName)
        {
            _fileName = fileName;
        }

        public string GetFileName()
        {
            return _fileName;
        }

        public void ReadData()
        {
            Console.WriteLine("Dosya adı okundu "+_fileName);
        }

        public void WriteData(object data)
        {
            Console.WriteLine("Dosya yazıldı "+_fileName);
        }
    }
}
