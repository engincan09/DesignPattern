using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Command
{
    // Nesnelere dönüştürdüğümüz her bir isteğe denk gelmektedir.
    // Command (IOrderCommand) arayüzünü uygular.
    // UML diyagramındaki ConcreteCommand sınıfına denk gelmektedir.
    public class SellStock : IOrderCommand
    {
        private StockManager _stockManager;

        public SellStock(StockManager stockManager)
        {
            _stockManager = stockManager;
        }

        public void Execute()
        {
            _stockManager.Sell();
        }
    }
}
