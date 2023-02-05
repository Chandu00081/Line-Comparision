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
            Console.WriteLine("Enter the points of First line");
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            double line1 = Math.Pow((x2 - x1), 2);
            double line2 = Math.Pow((y2 - y1), 2);
            double length1 = line1 + line2;
            double lengthOfLine1 = Math.Sqrt(length1);


            Console.WriteLine("Enter the points of Second line");
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            int q1 = int.Parse(Console.ReadLine());
            int q2 = int.Parse(Console.ReadLine());

            double line3 = Math.Pow((p2 - p1), 2);
            double line4 = Math.Pow((q2 - q1), 2);
            double length2 = line3 + line4;
            double lengthOfLine2 = Math.Sqrt(length2);

            if (lengthOfLine1 == lengthOfLine2)
                Console.WriteLine("Both Lines  are the  Equal Length");
            else if (lengthOfLine1 > lengthOfLine2)
                Console.WriteLine("First line is greater than Second line");
            else
                Console.WriteLine("Second line is greater than First line");

            Console.ReadLine();

        }

    }
}
