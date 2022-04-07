using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCalculation
{
    public class WageComputation
    {
        const int IS_PRESENT=1, IS_ABSENT = 0 , WAGE_PER_HR=20,FULL_DAY_HR=8,PART_TIME_HR=4,
            IS_FULL_DAY_PRESENT=1, IS_PART_TIME_PRESENT=2,WORKING_DAYS_A_MONTH=20;
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
            for (int i = 0; i < WORKING_DAYS_A_MONTH && empHrs<=100; i++)
            {

                Random random = new Random();
                int check = random.Next(0, 3);
                switch (check)
                {
                    case IS_ABSENT:
                        empHrs = 0;
                        break;
                    case IS_FULL_DAY_PRESENT:
                        empHrs = FULL_DAY_HR;
                        break;
                    case IS_PART_TIME_PRESENT:
                        empHrs = PART_TIME_HR;
                        break;
                }
                totalEmpWage += empHrs * WAGE_PER_HR;
            }

            Console.WriteLine("Total Emp Wage for a Day :" + totalEmpWage);
        }
    }
}
