using System;

namespace Exercise1
{
    public class Comparison
    {
        public static void Main(string[] args)
        {
            int number1; // declare first number to compare
            int number2; // declare second number to compare
            {
                Console.Write("Enter first integer: ");
                number1 = Convert.ToInt32(Console.ReadLine());

                // prompt user and read second number
                Console.Write("Enter second integer: ");
                number2 = Convert.ToInt32(Console.ReadLine());
            }

            if (number1 == number2)
            {
                Console.WriteLine("{0} == {1}", number1, number2);
            }

            if (number1 != number2)
            {
                Console.WriteLine("{0} != {1}", number1, number2);
            }

            if (number1 < number2)
            {
                Console.WriteLine("{0} < {1}", number1, number2);
            }

            if (number1 > number2)
            {
                Console.WriteLine("{0} > {1}", number1, number2);
            }

            if (number1 <= number2)
            {
                Console.WriteLine("{0} <= {1}", number1, number2);
            }

            if (number1 >= number2)
            {
                Console.WriteLine("{0} >= {1}", number1, number2);
            }

        }
    }
}