using System;

namespace VezbaPatterni.FactoryMethod
{
    public class Product2 : IProduct
    {
        public void Render()
        {
            Console.WriteLine("Render Product2");
        }
    }
}