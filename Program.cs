using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Learn your squares and cubes!");
                Console.WriteLine("Enter an integer: ");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("Number   Squared   Cubed");
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine(j + "        " + Square(j) + "         " + Cube(j));
                }
                run = Continue();
            }
        }
        public static int Square(int i)
        {
            return i * i;
        }
        public static int Cube(int i)
        {
            return i * i * i;
        }
        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Continue? y/n ");
            string answer = Console.ReadLine();

            if (answer == "y" || answer == "Y")
            {
                run = true;
            }
            else if (answer == "n" || answer == "N")
            {
                run = false;
                Console.WriteLine("Thank you for using this program. Goodbye!");
            }
            else
            {
                Console.WriteLine("Input not valid. Please try again.");
                run = Continue();
            }
            return run;

        }
    }
}
