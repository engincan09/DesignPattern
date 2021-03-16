using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Adapter
{
    // Daha sonradan dahil edilen yapının sisteme adepte edilmesi işlemi.
    // Sistemin kullandığı arayüzü uygular.
    // Bu sayede IJsonSerializer'i uygulayan bir sınıf örneği istendiğinde
    // bu sınıf örneğini vererek mevcut koda dokunmadan sistemin devam etmesi sağlaır.

    public class CustomSerializerAdapter : IJsonSerializer
    {
        public string SerializeObject(object obj)
        {
            CustomSerializer customSerializer = new CustomSerializer();
            return customSerializer.Serialize(obj);
        }
    }
}
