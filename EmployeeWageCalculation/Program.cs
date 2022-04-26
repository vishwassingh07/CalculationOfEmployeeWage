using System;

using EmployeeWageCalculation;
class Program
{
    public static void Main(String[] args)
    {
        //WageComputation calculation = new WageComputation();
        //calculation.EmployeeAttendence();
        WageComputation calculation2 = new WageComputation("Dmart", 20, 2, 10);
        calculation2.EmpWageCalculation();
        WageComputation calculation3 = new WageComputation("Realiance", 10, 4, 30);
        calculation3.EmpWageCalculation();
    }
}
