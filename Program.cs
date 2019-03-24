using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  The goal of the program is to simplify the exponent operations of an imaginary number.
//  For example:
//      i^(37)=i^(1)=i
//      i being the imaginary unit a.k.a. sqrt(-1).

//  The way the program works is by dividing the exponent by 4. Then, given the remainder, it will output the correct simplification.
//  The reason the exponent is divided is 4 is based on the trigonometric circle.
//  Because there are only 4 pure angles which we can obtain imaginary numbers,
//  and because the numbers being dealt with are pure imaginary numbers, 
//  their angles are either 0, 90, 180 or 270 degrees (360 degrees = 0 degrees).
//  Given this, we can deduce the angle of the number by its remainder of the division by 4.

//  If remainder is 0, then result is 1;
//  If remainder is 1, then result is i;
//  If remainder is 2, then result is -1;
//  If remainder is 3, then result is -i.

//  For example:
//      i^(71)
//      71 : 4 = 17, remainder 3
//      i^(71)= i^(3)= -i

namespace Imaginary_Number_Exponent_Simplifier
{
    class Program
    {
        static void Main(string[] args)
        {
            ExponentInput();
        }

        //Method that will input the exponent
        static void ExponentInput()
        {
            Console.Write("Insert exponent: ");
            int exponent = int.Parse(Console.ReadLine());

            //Jump to "Exponent Simplifier" method
            ExponentSimplifier(exponent);
        }

        static void ExponentSimplifier(int exponent)
        {
            int remainder = exponent % 4;

            switch (remainder)
            {
                case 0:
                    Console.WriteLine("i^{0} = 1",exponent);
                    break;
                case 1:
                    Console.WriteLine("i^{0} = -1", exponent);
                    break;
                case 2:
                    Console.WriteLine("i^{0} = i", exponent);
                    break;
                case 3:
                    Console.WriteLine("i^{0} = -i", exponent);
                    break;
            }
            Console.WriteLine();

            //Jump to "Repeat Action" method
            RepeatAction();
        }
        static void RepeatAction()
        {
            Console.WriteLine("Do you want to simplify another exponent? (y/n)");
            string input = Console.ReadLine().ToLower();

            Console.WriteLine();
            if (input == "y")
            {
                //Repeat program from the beginning
                ExponentInput();
            }
        }
    }
}
