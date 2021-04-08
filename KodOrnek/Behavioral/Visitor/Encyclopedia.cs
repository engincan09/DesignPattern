using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Visitor
{
    // UML diyagramındaki Element'ten türer.
    // Accept metoduna bulunduğu nesne örneği gönderilir.
    // UML diyagramındaki ConcreteElement yapısına denk gelir.
    public class Encyclopedia : Book
    {
        public override void Accept(IBookExportVisitor visitor)
        {
            visitor.ExportVisit(this);
        }
    }
}
