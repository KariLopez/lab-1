using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            bool repeat = true;
            string runAgain;
            String length, width, height;
            while (repeat == true)
            {
                Console.WriteLine("Please enter length of the room");
                length = Console.ReadLine();
                double ParsedLength = double.Parse(length);

                Console.WriteLine("Please enter the width");
                width = Console.ReadLine();
                double ParsedWidth = double.Parse(width);

                Console.WriteLine("Please enter the height of the room");
                height = Console.ReadLine();
                double ParsedHeight = double.Parse(height);

                double area = ParsedWidth * ParsedLength;
                Console.WriteLine("The area is " + area);

                double perimeter = ((2 * ParsedWidth) + (2 * ParsedLength));
                Console.WriteLine("The perimeter is " + perimeter);

                double volume = ParsedLength * ParsedWidth * ParsedHeight;
                Console.WriteLine("The volume is " + volume);
                Console.WriteLine("Would you like to run this program again? Y or N");
                runAgain = Console.ReadLine();
                if (runAgain == "y" || runAgain == "Y")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }
            }

        }
    }
}
