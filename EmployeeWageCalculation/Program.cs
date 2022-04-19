using System;

using EmployeeWageCalculation;
class Program
{
    public static void Main(String[] args)
    {
        WageComputation calculation = new WageComputation();
        calculation.EmployeeAttendence();
        WageComputation calculation2 = new WageComputation();
        calculation2.EmpWageCalculation();
    }
}
