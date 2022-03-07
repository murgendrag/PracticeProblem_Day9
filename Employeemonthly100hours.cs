using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_PracticeProblems
{
    public class Employeemonthly100hours
    {
           public void calmonthlywage()
            {

                int Working_Hour = 0;
                int Wage_per_hour = 20;
                int dailyWage;
                int totalWage = 0;
                int TOTAL_WORKING_HOUR = 100;
                int TOTAL_WORKING_DAY = 20;
                int PROBLEMATIC_SCENARIO = 96;

                int day = 0;
                while (day <= TOTAL_WORKING_DAY && Working_Hour <= TOTAL_WORKING_HOUR)
                {
                    if (Working_Hour == PROBLEMATIC_SCENARIO)
                    {
                        Working_Hour = Working_Hour + 4;//partime working hour added 
                        totalWage = Working_Hour * 20;
                    }
                    else
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
                    day++;
                }
                Console.WriteLine("Employee monthly wage is " + totalWage);
            }
        }
}
