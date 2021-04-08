using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CreationalPatterns.Builder
{
    // UML diyagramındaki Product'a denk gelen Lesson sınıfıa ait nesnenin oluşturulması için soyut arayüz sağlar.
    // Yapılması gereken adımlar içerisinde tanımlıdır.
    public abstract class LessonBuilder
    {
        public Lesson lesson;

        public abstract void GetLesson();
        public abstract void ApplyDiscount();
        public abstract void AddLessonNote();
        public abstract Lesson GetResult();
    }
}
