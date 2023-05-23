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
            // Dates();
            OverloadOperatorsWithFractions();
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

            // datesExcercises.DatesDeclaration();
            datesExcercises.DatesOperation();

        }

        static void OverloadOperatorsWithFractions()
        {
            FractionWithOverloadOperator f1 = new FractionWithOverloadOperator { Numerator = 1, Denominator = 3 };
            FractionWithOverloadOperator f2 = new FractionWithOverloadOperator { Numerator = 2, Denominator = 4 };

            FractionWithOverloadOperator f3 = f1 + f2;

            Console.WriteLine($"{f1} + {f2} = {f3}");
        }
    }
}