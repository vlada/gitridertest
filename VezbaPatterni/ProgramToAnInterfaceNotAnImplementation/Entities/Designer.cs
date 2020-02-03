using System;

namespace VezbaPatterni.ProgramToAnInterfaceNotAnImplementation.Entities
{
    public class Designer : IEmployee
    {
        public void DoWork()
        {
            Console.WriteLine("Designer do work");
        }
    }
}