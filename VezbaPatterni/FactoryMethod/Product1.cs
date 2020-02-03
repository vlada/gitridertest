using System;

namespace VezbaPatterni.FactoryMethod
{
    public class Product1 : IProduct
    {
        public void Render()
        {
            Console.WriteLine("Render Product1");
        }
    }
}