using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BeverageLavels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            double coeficient = volume / 100;
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine("{0}kcal, {1}g sugars", energy * coeficient, sugar * coeficient);
        }
    }
}
