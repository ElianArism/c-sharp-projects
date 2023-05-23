using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class FractionWithOverloadOperator
    {

        public int Numerator { get; set; } 
        public int Denominator { get; set; }

        public static FractionWithOverloadOperator operator +(FractionWithOverloadOperator f1, FractionWithOverloadOperator f2)
        {
            int commonDenominator = f1.Denominator * f2.Denominator;
            int numeratorAddition = f1.Numerator  * f2.Denominator  + f2.Numerator * f1.Denominator;

            return new FractionWithOverloadOperator
            {
                Numerator = numeratorAddition,
                Denominator = commonDenominator
            };
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
