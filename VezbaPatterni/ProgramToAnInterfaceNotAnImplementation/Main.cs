using System;
using VezbaPatterni.ProgramToAnInterfaceNotAnImplementation.Company;

namespace VezbaPatterni.ProgramToAnInterfaceNotAnImplementation
{
    public class ProgramToAnInterfaceNotAnImplementationMain
    {
        public static void  Run()
        {
            new DeveloperCompany().DoWork();
            Console.WriteLine("==========================");
            new GameCompany().DoWork();
             
        }
    }
}