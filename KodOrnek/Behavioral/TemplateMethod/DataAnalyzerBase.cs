using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.TemplateMethod
{
    //Metot iskeletimizi ve soyutlanmış metotları içerir.
    //UML diyagramındaki AbstractClass yapısıne denkgeliyor.
    public abstract class DataAnalyzerBase
    {
        //Metot iskeletimiz.
        public void AnalyzerDataOfLastWeek()
        {
            object data = GetDataOfLastWeek();
            object result = AnalyzeData(data);
            ExportResult(result);
        }
        private object GetDataOfLastWeek()
        {
            //Burada verinin çağrılma süreçleri yer alır.
            //Default olarak bir obje döner
            Console.WriteLine("Metot worked: GetDataOFLastWeek");
            return new object();
        }
        private object AnalyzeData(object data)
        {
            // Burada verinin analizi süreci yer almaktadır.
            // Analiz sonuçları default olarak bir obje dönmektedir.
            Console.WriteLine("Method worked: AnalyzeData");
            return new object();
        }

        // Alt sınıflar tarafından uygulanmasını istediğimiz metottur.
        // Metot iskeleti içerisinde farklılık gösterecek olan metotumuzdur.
        public abstract void ExportResult(object result);
    }
}
