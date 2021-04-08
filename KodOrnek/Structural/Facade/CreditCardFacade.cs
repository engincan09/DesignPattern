using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Facade
{
    public class CreditCardFacade
    {
        public void CreateCreditCart(Customer customer)
        {
            CreditCardManager creditCardManager = new CreditCardManager();
            BlackListService blackListService = new BlackListService();
            if (blackListService.CheckCustomerBlackList(customer))
            {
                creditCardManager.CreateCreditCart(customer);
            }
        }
    }
}
