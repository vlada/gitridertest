using System;

namespace VezbaPatterni.FactoryMethod
{
    public class ClientApp
    {
        private readonly ICreator _creator;

        public ClientApp(ICreator concreteCreator1)
        {
            _creator = concreteCreator1;
            Console.WriteLine($"Launched with {concreteCreator1.GetType()}");
        }

        public void Operation()
        {
            _creator.Create().Render();
            
            
        }
    }
}