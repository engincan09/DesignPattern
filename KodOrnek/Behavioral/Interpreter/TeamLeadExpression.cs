using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Interpreter
{
    // Dil bilgisindeki terminal ifadeler üzerinde işlem yapar.
    // UML diyagramındaki TerminalExpression sınıfına denk gelmektedir.
    public class TeamLeadExpression : IJobExpression
    {
        public void Interpret(Context context)
        {
            if (context.formul.Contains("L"))
            {
                context.totalPoint += 7000;

            }
        }
    }
}
