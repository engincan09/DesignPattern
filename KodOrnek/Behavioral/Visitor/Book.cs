﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Visitor
{
    // Temel sınıftır.
    // Yeni davranışları Accept metotu ile alır.
    // UML diyagramındaki Element yapısına denk gelmektedir.
    public abstract class Book
    {
        public string name;
        public string author;
        public string categoryName;

        public abstract void Accept(IBookExportVisitor visitor);
    }
}
