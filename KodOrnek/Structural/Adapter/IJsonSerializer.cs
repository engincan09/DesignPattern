using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Adapter
{
    // Sistem bu arayüzü uygulayarak çalışmaktadır.
    public interface IJsonSerializer
    {
        string SerializeObject(object obj);
    }
}
