using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_PracticeProblems
{
    public class EmployeeWage
    {
        public void CalEmployeeWage()
        {
            int Employee_Present = 1;
            int Employee_Wage;
            int Working_Hour = 8;
            int Wage_per_hour = 20;

            Random random = new Random();
            int number = random.Next(2);
            if (number == Employee_Present)
            {
                Console.WriteLine("Employee is present");
                Employee_Wage = Working_Hour * Wage_per_hour;
                Console.WriteLine("Employee Daily Wage is " + Employee_Wage);
            }
            else
            {
                Console.WriteLine("Employee is absent");
                Console.WriteLine("Employee Daily Wage is 0");
            }
        }
    }
}
