using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Interpreter
{
    //Yorumlama işleminin tanımlandığı arayüzdür.
    //UML diyagramındaki Expression arayüzdür.
    public interface IJobExpression
    {
        void Interpret(Context context);
    }
}
