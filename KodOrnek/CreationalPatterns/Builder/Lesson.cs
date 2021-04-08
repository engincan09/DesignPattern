using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CreationalPatterns.Builder
{
    // UML diyagramındaki Product sınıfına denk gelmektedir.
    // Farklı sunumları olan sınıfımız budur.
    public class Lesson
    {
        public int id;
        public string name;
        public int price;
        public int discountedPrice;
        public bool discountApplied;
        public string lessonNote;
    }
}
