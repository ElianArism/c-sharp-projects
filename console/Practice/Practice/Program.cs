using System;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Arrays();
            // Random();
            Dates();
        }


        static void Arrays()
        {
            ArrayExcercises arrExcercises = new ArrayExcercises();

            // arrExcercises.arrayDeclaration();
            // arrExcercises.maxtrixDeclaration(); 
            // arrExcercises.vectorDeclaration();
        }

        static void Random()
        {
            // Print a piramid 
            int i = 1;
            while(true)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write(" 0 ");
                }
                Console.WriteLine();

                i *= 2;

                if (i > 10) break; 
            }
        }

        static void Dates()
        {
            Dates datesExcercises = new Dates();
            datesExcercises.DatesDeclaration();
        }
    }
}