using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            //class creation 
            Console.WriteLine("Hello World!");
            decimal x;
            double y = 55;
            float z = 5.5f;

            string correctAns = "pushkar";
            string guessAns = "";
            bool limitReached = false;
            int countGuess = 0;

            do
            {
                if (countGuess < 3)
                {
                    Console.WriteLine("Enter Guess");
                    guessAns = Console.ReadLine();
                    countGuess++;
                }
                else
                {
                    limitReached = true;
                }
            }
            while (guessAns != correctAns && !limitReached);
            if (limitReached)
            {
                Console.WriteLine("Lose");
            }
            else
            {
                Console.WriteLine("Win");
            }

            Book b1 = new Book("Math");

            b1.BookName = "cat";
            Console.WriteLine(b1.BookName);
            Console.WriteLine(Book.count);
            Book.StaticExample();
        }
    }
}
