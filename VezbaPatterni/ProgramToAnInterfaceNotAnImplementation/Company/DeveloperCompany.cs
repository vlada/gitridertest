using System.Collections.Generic;
using VezbaPatterni.ProgramToAnInterfaceNotAnImplementation.Entities;

namespace VezbaPatterni.ProgramToAnInterfaceNotAnImplementation.Company
{
    public class DeveloperCompany : Company
    {
        protected override List<IEmployee> GetEmployees()
        {
            return new List<IEmployee>() {new Developer(), new Designer()};
        }
    }
}