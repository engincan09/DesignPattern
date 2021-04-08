using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CreationalPatterns.Builder
{   // Builder arayüzünü kullanarak nesne örneklemesi yapar.
    // UML diyagramındaki Director'a denk gelmektedir.
    public class LessonDirector
    {
        private LessonBuilder lessonBuilder;

        public LessonDirector(LessonBuilder lessonBuilder)
        {
            this.lessonBuilder = lessonBuilder;
        }

        public void Make()
        {
            lessonBuilder.GetLesson();
            lessonBuilder.ApplyDiscount();
            lessonBuilder.AddLessonNote();
        }
    }
}
