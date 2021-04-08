using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Decorator
{
    //Constructor ile özelliklerini değiştirilmesi istenen referansı tutuyoruz.
    //Değiştirilmesi istenen metotları abstract olarak işaretliyoruz.
    // UML diyagramındaki BaseDecorator yapısına denk gelmektedir.
    public abstract class BaseDataSourceDecorator : IDataSource
    {
        protected IDataSource _dataSource;

        protected BaseDataSourceDecorator(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public abstract string GetFileName();
        public abstract void ReadData();
        public abstract void WriteData(object data);
    }
}
