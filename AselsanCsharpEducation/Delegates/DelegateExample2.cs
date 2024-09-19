using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Delegates
{
    public enum SalaryType
    {
        Manager = 1,
        Editor = 2,
        Employee = 3
    }


    internal delegate decimal CalculateSalaryDelegate(decimal baseSalary, decimal bonus, int childCount);

    internal class Calculate
    {
        public decimal CalculateSalaryGood(decimal baseSalary, decimal bonus, int childCount,
            CalculateSalaryDelegate calculate)
        {
            return calculate(baseSalary, bonus, childCount);
            //return calculate.Invoke(baseSalary, bonus, childCount);
        }

        public decimal CalculateSalary(decimal baseSalary, decimal bonus, int childCount, SalaryType salaryType)
        {
            decimal sumSalary = 0;

            switch (salaryType)
            {
                case SalaryType.Manager:

                    sumSalary = ManagerCalculate(baseSalary, bonus, childCount);
                    break;
                case SalaryType.Editor:
                    sumSalary = EditorCalculate(baseSalary, bonus, childCount);
                    break;
                case SalaryType.Employee:
                    sumSalary = EmployeeCalculate(baseSalary, bonus, childCount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(salaryType), salaryType, null);
            }

            return sumSalary;
        }

        public decimal ManagerCalculate(decimal baseSalary, decimal bonus, int childCount)
        {
            return baseSalary * bonus * childCount * 5;
        }

        public decimal EditorCalculate(decimal baseSalary, decimal bonus, int childCount)
        {
            return baseSalary * bonus * childCount * 3;
        }

        public decimal EmployeeCalculate(decimal baseSalary, decimal bonus, int childCount)
        {
            return baseSalary * bonus * childCount * 1;
        }
    }
}