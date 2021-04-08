using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Facade
{
    ///Kara Liste ile ilgili işlemlerin yapıldığı sınıfımız
    public class BlackListService
    {
        public bool CheckCustomerBlackList(Customer customer)
        {
            // Müşterinin kara listede olup olmadığının kontrolünün yapıldığı yer.
            // Kara listede ise false, değilse true dönmekte olduğunu var sayalım.
            // Burada veri tabanı kodları ya da harici bir servis ile iletişim sağlanabilir.
            return true;
        }
    }
}
