using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_PracticeProblems
{
    public class EmployeeAttendance
    {
        
        public void Employeeattcheck()
        {
            
            int Emplopee_Present = 1;
            Random random = new Random();
            int number = random.Next(2);
            if (number == Emplopee_Present)
            {
                Console.WriteLine("Employee is present");

            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
    
}

