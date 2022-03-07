using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_PracticeProblems
{
    public class MonthlyWage
    {
        public void calmonthlywage()
        {

            int Working_Hour=0;
            int Wage_per_hour = 20;
            int dailyWage;
            int totalWage = 0;

            int day ;
            for (day = 0; day < 20; day++)
            {
                Random random = new Random();
                int number = random.Next(3);
                switch (number)
                {
                    case 0:
                        Console.WriteLine(" Employee is absent");
                        Working_Hour = 0;
                        break;
                    case 1:
                        Console.WriteLine("Employee is present");
                        Working_Hour = 8;
                        break;
                    case 2:
                        Console.WriteLine("Employee is working partime");
                        Working_Hour = 4;
                        break;
                }
                        dailyWage = Working_Hour * Wage_per_hour;
                        totalWage = totalWage + dailyWage;
                
                
            }
            Console.WriteLine("Employee monthly wage is " +totalWage);
        }
    }
}
