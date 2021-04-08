﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Visitor
{
    // Her ConcreteVisitor örneği için metot temsil eder.
    // Parametre olarak Element sınıfından türeyen sınıfların örneğini alır.
    // UML diyagramındaki Visitor yapısına denk gelir.
    public interface IBookExportVisitor
    {
        void ExportVisit(Magazine magazine);
        void ExportVisit(Encyclopedia encyclopedia);
    }
}
