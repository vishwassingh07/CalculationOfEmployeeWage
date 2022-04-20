using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCalculation
{
    public class WageComputation
    {
        const int IS_PRESENT=1, IS_ABSENT = 0, IS_FULL_DAY_PRESENT=1, IS_PART_TIME_PRESENT=2;
        int empHrs, totalEmpWage;
        public void EmployeeAttendence()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == IS_PRESENT)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
        }
    
        public int EmpWageCalculation(string company, int wagePerHr, int workingDaysAMonth, int maxHrPerMonth )
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs < maxHrPerMonth && totalWorkingDays < workingDaysAMonth)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME_PRESENT:
                        empHrs = 4;
                        break;
                    case IS_FULL_DAY_PRESENT:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#" + totalWorkingDays + "Employee Hours " + empHrs);
                
            }
            int totalEmpWage = totalEmpHrs * wagePerHr;
            Console.WriteLine("Total Employee Wage Of " + company + " is " + totalEmpWage);
            return totalEmpWage;

            
        }
    }
}
