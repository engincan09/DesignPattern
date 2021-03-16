using DesignPattern.CreationalPatterns.Builder;
using DesignPattern.CreationalPatterns.Prototype;
using DesignPattern.Structural.Adapter;
using KodOrnek.CreationalPatterns.AbstractFactory;
using KodOrnek.CreationalPatterns.Factory;
using KodOrnek.Singleton;
using System;

namespace KodOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            var customOperation = new CustomOperation(new CustomSerializerAdapter());

            string serializedObject = customOperation.SerializeObject(new object());

        }
    }
}
