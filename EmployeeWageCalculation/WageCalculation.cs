using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCalculation
{
    public class WageComputation
    {
        const int IS_PRESENT = 0,WAGE_PER_HR=20,FULL_DAY_HR=8;
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
        public void EmpWageCalculation()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == IS_PRESENT)
            {
                empHrs = FULL_DAY_HR;
            }
            else
            {
                empHrs = 0;
            }
            totalEmpWage = empHrs * WAGE_PER_HR;
            Console.WriteLine("Total Emp Wage for a Day :" + totalEmpWage);
        }
    }
}
