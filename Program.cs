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
            int dayHours = 0;
            Console.WriteLine("Welcome to Employee Wage Computation Program.");
            /// Generate random number
            Random r = new Random();
            int randomNumber=r.Next(0, 3);
            /// Condition to Check if Employee is Present or Absent.
            /// Displays Employee is present or Absent based on Random Number.
            if (randomNumber == 2)
            {
                Console.WriteLine("Employee is Present for Full Day!");
                dayHours = 8;
            }
            else if(randomNumber==1){
                Console.WriteLine("Employee is Present for Half day!");
                dayHours = 4;

            }
            else {
                Console.WriteLine("Employee is Absent!");
            }
            ///Displays the Daily Wage of the Employee.
            Console.WriteLine("The Daily Wage of the Employee is "+ WAGE_PER_HOUR*dayHours);
        }
    }
}
