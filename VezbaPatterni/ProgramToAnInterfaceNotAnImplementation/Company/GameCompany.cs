using System.Collections.Generic;
using VezbaPatterni.ProgramToAnInterfaceNotAnImplementation.Entities;

namespace VezbaPatterni.ProgramToAnInterfaceNotAnImplementation.Company
{
    public class GameCompany : Company
    {
        protected override List<IEmployee> GetEmployees()
        {
            return new List<IEmployee>() {new Developer(), new Designer(), new Developer(),};
        }
    }
}