using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Inlämning1
{
    public struct Rational
    {
        private int numerator;
        private int denominator;

        public Rational(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new DivideByZeroException();

            this.numerator = numerator;
            this.denominator = denominator;
        }

        #region Arithmetic Operators

        public static Rational operator +(Rational x, Rational y)
        {   
            if (x.denominator == y.denominator)
            {
                return new Rational(x.numerator + y.numerator, x.denominator);
            }

            return new Rational(
                (x.numerator * y.denominator) + (y.numerator * x.denominator),
                x.denominator * y.denominator
                );
        }
        public static Rational operator -(Rational x, Rational y)
        {
            if (x.denominator == y.denominator)
            {
                return new Rational(
                     x.numerator - y.numerator, x.denominator);
            }

            return new Rational(
                (x.numerator * y.denominator) - (y.numerator * x.denominator),
                x.denominator * y.denominator
                );
        }
        public static Rational operator *(Rational x, Rational y)
        {
            return new Rational(
                x.numerator * y.numerator,
                x.denominator * y.denominator
            );
        }
        public static Rational operator /(Rational x, Rational y)
        {
            return new Rational(
                x.numerator * y.denominator,
                x.denominator * y.numerator
            );
        }

        #endregion

        #region Comparison operators

        public static bool operator ==(Rational x, Rational y)
        {
            return x.numerator * y.denominator == x.denominator * y.numerator;
        }
        public static bool operator !=(Rational x, Rational y)
        {
            return x.numerator * y.denominator != x.denominator * y.numerator;
        }

        #endregion

        #region Cast operators

        public static explicit operator double(Rational x)
        {
            return (double)x.numerator / x.denominator;
        }
        public static explicit operator decimal(Rational x)
        {
            return (decimal)x.numerator / x.denominator;
        }

        public static explicit operator Rational(int x)
        {
            return new Rational(x, 1);
        }

        #endregion

        public static Rational Parse(string str)
        {
            var parts = str.Split('/',
                StringSplitOptions.TrimEntries);

            int numerator = int.Parse(parts[0]);
            var denominator = parts.Length == 2
                ? int.Parse(parts[1])
                : 1;
              
            return new Rational(numerator, denominator);
        }

        public static Rational decimalToRational(string str)
        {
            
            var parts = str.Split('.', StringSplitOptions.TrimEntries);
            var wholeNum = double.Parse(parts[0]);
            var decNum = parts.Length == 2 ? double.Parse(parts[1]) : 1;
            var count = decNum.ToString().Length;
            var denominator = 1;
               for (int i = 1; i <= count; i++)
                {
                    denominator = denominator * 10;                
                    
                }

            var temp = double.Parse(parts[0] + "." + parts[1]);
            var numerator = temp * denominator;
            
            return new Rational((int)numerator, denominator);

        }

        public override string ToString()
        {
            if (numerator == 0)
                return "0";

            if (denominator == 1)
                return numerator.ToString();

            return $"{numerator}/{denominator}";
        }

        static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
        public static Rational Simplyfy(Rational sum)
        {
            var numerator = sum.numerator;
            var denominator = sum.denominator;
            var gcd = GCD(numerator, denominator);
            numerator = numerator / gcd;
            denominator = denominator / gcd;
            if (denominator < 0)
            {
                numerator = numerator * -1;
                denominator = denominator * -1;
            }
            
            return new Rational(numerator, denominator);
        }
    }    
}