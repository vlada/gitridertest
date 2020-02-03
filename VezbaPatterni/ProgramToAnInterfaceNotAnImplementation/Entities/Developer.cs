using System;

namespace VezbaPatterni.ProgramToAnInterfaceNotAnImplementation.Entities
{
    public class Developer : IEmployee
    {
        public void DoWork()
        {
            Console.WriteLine("Developer do work");
        }
    }
}