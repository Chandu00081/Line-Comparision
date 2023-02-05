using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace line_comparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the all Points");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            double l1 = Math.Pow((x2 - x1), 2);
            double l2 = Math.Pow((y2 - y1), 2);
            double length = l1 + l2;
            double lengthOfLine = Math.Sqrt(length);

            Console.WriteLine("Lenth Of The Line is:" + lengthOfLine);
        }
    }
}
