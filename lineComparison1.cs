using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_PracticeProblems
{
    public class lineComparison1
    {
        public  void calculatelength()
        {
            float length;

            Console.WriteLine("Enter the corordinates of line x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the corordinates of line x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the corordinates of line y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the corordinates of line y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            int x = (x2 - x1) * (x2 - x1);
            int y = (y2 - y1) * (y2 - y1);
            length = x + y;
            Console.WriteLine(Math.Sqrt(length));
        }
    }
}
