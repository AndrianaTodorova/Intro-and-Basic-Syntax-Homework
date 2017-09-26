using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double milesToKilometers = miles * 1.60934;

            Console.WriteLine($"{milesToKilometers:f2}");
        }
    }
}
