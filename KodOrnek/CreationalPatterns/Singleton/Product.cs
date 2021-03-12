using System;
using System.Collections.Generic;
using System.Text;

namespace KodOrnek.Singleton
{
    public class Product
    {
        //Nesnenin daha önceden oluşturulmadığını anlayabilmek için statik instance özelliği tanımladık.
        public static Product Instance { get; set; }

        //Sınıfımızın construct metodunu private yada protected tanımlıyoruz.
        private Product()
        {
            //Oluşum sırasında kullanmak istediğimiz yapılar.
        }

        // Dışarıdan sınıfımızı çağıracağımız metodumuz.
        public static Product GetInstance()
        {
            // eğer daha önce örnek oluşturulmamış ise sınıfın tek örneğini oluştur
            if (Instance == null)
            {
                Instance = new Product();
            }
            return Instance;
        }
    }
    
}
