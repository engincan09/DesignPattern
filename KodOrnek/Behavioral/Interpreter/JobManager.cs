using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Interpreter
{
    public class JobManager
    {
        public List<IJobExpression> CreateExpressionTree(string formul)
        {
            List<IJobExpression> tree = new List<IJobExpression>();
            foreach (var role in formul)
            {
                switch (role)
                {
                    case 'G':
                        tree.Add(new DeveloperExpression());
                        break;
                    case 'M':
                        tree.Add(new AccountingExpression());
                        break;
                    case 'L':
                        tree.Add(new TeamLeadExpression());
                        break;
                    default:
                        throw new Exception("Unexpected role!");
                }
            }
            return tree;
        }

        public void RunExpression(Context context)
        {
            foreach (IJobExpression expression in CreateExpressionTree(context.formul))
            {
                expression.Interpret(context);
            }
        }
    }
}
