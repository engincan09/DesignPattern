using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Decorator
{
    //Yeni davranışları tanımladığımız sınıf
    // UML diyagramındaki BaseDecorator (BaseDataSourceDecorator) sınıfından türer.
    // UML diyagramındaki ConcreteDecorator sınıfına denk gelmektedir.
    public class ComporessionDecorator : BaseDataSourceDecorator
    {
        public ComporessionDecorator(IDataSource dataSource) : base(dataSource)
        {

        }
        public override string GetFileName()
        {
            return base._dataSource.GetFileName();
        }

        public override void ReadData()
        {
            //veriyi okurken referansını tuttuğumuz sınıfın kendi davranışlarını kullanacak
            base._dataSource.ReadData();
        }

        public override void WriteData(object data)
        {
            //Gelen veriyi sıkıştırma işlemleri
            Console.WriteLine("Veri Sıkıştırıldı");

            //Sıkıştırma işlemi sonrası yazma işlemi
            Console.WriteLine("Veri sıkıştırılarak yazıldı");
        }
    }
}
