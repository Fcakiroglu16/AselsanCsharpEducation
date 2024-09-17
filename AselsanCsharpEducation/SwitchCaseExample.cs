using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation
{
    public class UserManagerClient
    {
        public void X()
        {
            var userManager = new UserManager();

            userManager.AssignToUser(1, "ahmet");
            userManager.AssignToUser(Roles.Admin, "ahmet");
        }
    }


    public class UserManager
    {
        public void AssignToUser(int roleNumber, string userName)

        {
            switch (roleNumber)
            {
                case 0:
                    Console.WriteLine("0");
                    break;
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
            }
        }

        public void AssignToUser(Roles role, string userName)
        {
            switch (role)
            {
                case Roles.Admin:
                    Console.WriteLine("Admin");
                    break;
                case Roles.Manager:
                    Console.WriteLine("Manager");
                    break;
                case Roles.Editor:
                    Console.WriteLine("Editor");
                    break;
            }
        }
    }

    public class SalaryCalculate
    {
        public decimal Calculate3(string baseSalary, Roles role)
        {
            if (!decimal.TryParse(baseSalary, out decimal baseSalaryAsDecimal))
            {
                throw new Exception("");
            }

            if (role == Roles.Admin)
            {
                return baseSalaryAsDecimal * .12m;
            }

            throw new Exception();
        }

        public decimal Calculate2(decimal baseSalary, Roles role)
        {
            return role switch
            {
                Roles.Admin => baseSalary * 2,
                Roles.Manager => baseSalary * 1.5m,
                Roles.Editor => baseSalary * 1.2m,
                _ => throw new NotImplementedException()
            };
        }

        public decimal Calculate(decimal baseSalary, Roles role)
        {
            decimal totalSalary = 0;

            switch (role)
            {
                case Roles.Admin:
                    totalSalary = baseSalary * 2;
                    break;

                case Roles.Manager:
                    totalSalary = baseSalary * 1.5m;
                    break;
                case Roles.Editor:
                    totalSalary = baseSalary * 1.2m;
                    break;

                default:
                    throw new NotImplementedException();
                    break;
            }

            return totalSalary;
        }
    }
}