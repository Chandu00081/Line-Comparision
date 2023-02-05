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
            int x1, x2, y1, y2;
            Console.WriteLine("Please Enter X1:");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter X2:");
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Y1:");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Y2:");
            y2 = int.Parse(Console.ReadLine());

            double linelength1=Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Length of Line 1 is : {linelength1}");

            int l1, l2, m1, m2;

            Console.WriteLine("Please Enter l1:");
            l1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter l2:");
            l2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter m1:");
            m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter m2:");
            m2 = int.Parse(Console.ReadLine());

            double linelength2 = Math.Sqrt(Math.Pow(l2 - l1, 2) + Math.Pow(m2 - m1, 2));
            Console.WriteLine($"length of the Line 2 is : {linelength2}");

            if (int.Equals(linelength1, linelength2))
            {
                Console.WriteLine("length of Two lines are Equal");
            }
            else
            {
                Console.WriteLine("length of Two lines are Not Equal");
            }


        }

    }
}
