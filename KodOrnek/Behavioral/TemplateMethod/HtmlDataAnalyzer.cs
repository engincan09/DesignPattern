using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.TemplateMethod
{
    public class HtmlDataAnalyzer : DataAnalyzerBase
    {
        public override void ExportResult(object result)
        {
            // Durumun HTML'e dönüştürülmesi işlemleri yer alacaktır.
            Console.WriteLine("HTML exported.");

        }
    }
}
