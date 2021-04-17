using System;
using System.Collections.Generic;
using System.Text;

namespace KodOrnek.Singleton
{
    public class Product
    {
        //Nesnenin daha önceden oluşturulup oluşturulmadığını anlayabilmek için statik instance özelliği tanımladık.
        public static Product Instance { get; set; }
        public static Object _lock = new object();

        //Sınıfımızın construct metodunu private yada protected tanımlıyoruz. İstemci new anahtar kelimesiye örneğini alamaz.
        private Product()
        {
            //Oluşum sırasında kullanmak istediğimiz yapılar.
        }

        // Dışarıdan sınıfımızı çağıracağımız metodumuz.

        public static Product GetInstance()
        {
            // eğer daha önce örnek oluşturulmamış ise sınıfın tek örneğini oluştur

            //Multi - thread uygulamalar da yani aynı anda birden fazla iş yapabilen uygulamalarda
            //Nesnenin daha örneğinin oluşmadığı esnada if(Instance==null) durumuna aynı anda bir den fazla thread girebilir.
            //Bu sayede o sınıfa ait birden fazla nesne örneği bulunur.
            //Bu durumda C# dilinde bulunan lock keywordü ile kontrol edebiliriz.
            //Aynı anda sadece bir yapının erişmesini sağlarız.

            if (Instance == null)
            {
                lock (_lock)
                {
                    Instance = new Product();
                }
              
            }
            return Instance;
        }
    }
    
}
