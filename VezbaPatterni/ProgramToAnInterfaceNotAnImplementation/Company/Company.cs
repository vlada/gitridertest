using System.Collections.Generic;
using VezbaPatterni.ProgramToAnInterfaceNotAnImplementation.Entities;

namespace VezbaPatterni.ProgramToAnInterfaceNotAnImplementation.Company
{
    public abstract class Company
    {
        protected abstract List<IEmployee> GetEmployees();

        public void DoWork()
        {
            GetEmployees().ForEach(employee => employee.DoWork());
        }
    }
}