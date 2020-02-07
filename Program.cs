using System;

namespace ConditioinalStatementTylerGunnells
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello," + "\n");

            Console.WriteLine("What grade do you expect to get this semester in ISM-4300?");
            Console.WriteLine("Out of 100 possible points please enter an integer value." + "\n");

            Console.Write("Enter Integer:");
            int inputValue;

            while (!int.TryParse(Console.ReadLine(), out inputValue))
            {
                Console.Clear();
                Console.WriteLine("Please enter an integer value.");
            }
            Console.WriteLine("\n" + "You Entered:" + inputValue);


            if (inputValue >= 98 && inputValue <= 100)
            {
                Console.WriteLine("You are expecting to recieve an 'A+'");
            }
            else if (inputValue >= 92 && inputValue <= 97)
            {
                Console.WriteLine("You are expecting to recieve an A");
            }
            else if (inputValue >= 90 && inputValue <= 91)
            {
                Console.WriteLine("You are expecting to recieve a A-");
            }
            else if (inputValue >= 88 && inputValue <= 89)
            {
                Console.WriteLine("You are expecting to recieve a B+");
            }
            else if (inputValue >= 82 && inputValue <= 87)
            {
                Console.WriteLine("You are expecting to recieve an B");
            }
            else if (inputValue >= 80 && inputValue <= 81)
            {
                Console.WriteLine("You are expecting to recieve a B-");
            }
            else if (inputValue >= 78 && inputValue <= 79)
            {
                Console.WriteLine("You are expecting to recieve a C+");
            }
            else if (inputValue >= 72 && inputValue <= 77)
            {
                Console.WriteLine("You are expecting to recieve an C");
            }
            else if (inputValue >= 70 && inputValue <= 71)
            {
                Console.WriteLine("You are expecting to recieve a C-");
            }
            else if (inputValue >= 68 && inputValue <= 69)
            {
                Console.WriteLine("You are expecting to recieve a D+");
            }
            else if (inputValue >= 62 && inputValue <= 67)
            {
                Console.WriteLine("You are expecting to recieve an D");
            }
            else if (inputValue >= 60 && inputValue <= 61)
            {
                Console.WriteLine("You are expecting to recieve a D-");
            }
            else
            {
                Console.WriteLine("You are expecting to recieve an F.");
            }
        }
    }
}
