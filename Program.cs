using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Linecomparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the line comparision program");
           //UC1- length between two points (first points)
            
            Console.WriteLine("Enter the values of x1 y1 & x2 y2");
            double[] points = new double[4];
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2= Convert.ToDouble(Console.ReadLine());
            double length1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("Length of line1 is {0}", length1 ) ;


            // UC2- Second points

            Console.WriteLine("Enter the values of x3 y3 & x4 y4");
            double[] points2= new double[4];
            double x3 = Convert.ToDouble(Console.ReadLine());
            double x4 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            double y4 = Convert.ToDouble(Console.ReadLine());



            double length2 = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
            Console.WriteLine("Length of line2 is {0}", length2);

            //Uc3 -comparision between 2 lines
            if (length2 == length1)
                Console.WriteLine("Line2 is equal to Line1");
            else if (length2 > length1)
                Console.WriteLine("Line2 is greaterthan Line1");
            else
                    Console.WriteLine ("Line2 is lessthan Line1");
            Console.ReadLine();

        }
    }
}
