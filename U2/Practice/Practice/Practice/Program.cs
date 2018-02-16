using System;

namespace Practice
{
    class Conditionals
    {
        static void Main(string[] args)
        {
            int grade = 90;
            if (grade < 70)
            {
            Console.WriteLine("I an sorry, but you failed");
            }
            else if (grade < 80)
            {
                Console.WriteLine("You passed with a C");
            }
            else if (grade < 90)
            {
                Console.WriteLine("You passed with a B");
            }
            else
            {
                Console.WriteLine("You passed with a A");
            }
        }
    }
}

        

