/*
 *  C# CODING STANDARDS - LINE SPACE
 * NOTE - A SINGLE BLANK LINE SEPARATES THE TWO BLOCKS i.e. USING STATEMENTS, CLASS DECLARATION, etc
 */

/******************************************************************************
 *  Compilation:  C:\Users\Santhu\source\repos\EmployeeWageComputation_C\bin\Debug\netcoreapp3.1\EmployeeWageComputation_C.exe
 *  Execution:    EmployeeWageComputation_C.exe
 *  
 *  Purpose: Computes Employee Wages.
 *
 *  @author  Santhosh V
 *  @version 1.0
 *  @since   06-08-2017
 *
 ******************************************************************************/

/// Including the requried assemblies in to the program
using System;

namespace EmployeeWageComputation_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int WAGE_PER_HOUR = 20;
            int monthlyWage = 0;
            int totalWorkingHours = 0;
            Console.WriteLine("Welcome to Employee Wage Computation Program.");
            ///To Compute Monthly Wage for a Month Consisting of 20 Working Days
            for (int i = 1; i<=20; i++) {
                if (totalWorkingHours>=100) {
                    break;
                }
                int dailyWage = 0;
                int dayHours = 0;
                /// Generate random number
                Random r = new Random();
                int randomNumber = r.Next(0, 3);
                /// Condition to Check if Employee is Present or Absent.
                /// Displays Employee is present or Absent based on Random Number.
                switch (randomNumber)
                {
                    case 2:
                        dayHours = 8;
                        break;

                    case 1:
                        dayHours = 4;
                        break;
                    case 0:
                        dayHours = 0;
                        break;
                }
                ///To Compute Total Working Hours
                totalWorkingHours = totalWorkingHours + dayHours;
                ///To Compute Daily Wage.
                dailyWage = WAGE_PER_HOUR * dayHours;
                ///To Compute MonthlyWage.
                monthlyWage = monthlyWage + dailyWage;
                ///Displays the Daily Wages and Monthly wages of the Employee.
                Console.WriteLine("Day: "+i+"  Work Hours : "+dayHours +"  Total Working Hours: "+totalWorkingHours+"  DailyWage: "+dailyWage+"  Monthly Wage: "+monthlyWage);
            }
        }
    }
}
