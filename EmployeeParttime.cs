using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_PracticeProblems
{
    public class EmployeeParttime
    {
        public void CalEmployeewage()
        {
            int Employee_Present = 1;
            int Employee_parttime = 2;
            int Employee_Wage;
            int Working_Hour = 8;
            int Wage_per_hour = 20;
            int Part_Time_hour = 4;

            Random random = new Random();
            int number = random.Next(3);
            if (number == Employee_Present)
            {
                Console.WriteLine("Employee is present");
                Employee_Wage = Working_Hour * Wage_per_hour;
                Console.WriteLine("Employee Daily Wage is " + Employee_Wage);
            }
            else if (number == Employee_parttime)
            {
                Console.WriteLine("Employee is working partime");
                Employee_Wage = Part_Time_hour * Wage_per_hour;
                Console.WriteLine("Employee Daily wage is " + Employee_Wage);
            }

            else
            {
                Console.WriteLine("Employee is absent");
                Console.WriteLine("Employee Daily Wage is 0");
            }
        }
    }
}
