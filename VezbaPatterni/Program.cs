using System;
using VezbaPatterni.FactoryMethod;


namespace VezbaPatterni
{
    class Program
    {
        public delegate void Del(string message);
        
        public static  void DelMethod(string message)
        {
            Console.WriteLine("Delmethod {0}", message);
        }


        
        
        static void Main(string[] args)
        {
              
        //  ProgramToAnInterfaceNotAnImplementation.ProgramToAnInterfaceNotAnImplementationMain.Run();
        new ClientApp(new ConcreteCreator1()).Operation();
        }
    }
}