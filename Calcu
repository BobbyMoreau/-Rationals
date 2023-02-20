using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inlämning1;


namespace Inlämning1
{
    partial class Calcu
    {
        public string num1 = string.Empty;
        public string num2 = string.Empty;
        public Rational rational1 = new Rational(int.MinValue, int.MaxValue);
        public Rational rational2 = new Rational(int.MinValue, int.MaxValue);
        public Rational sum = new Rational(int.MinValue, int.MaxValue);
        bool contA = true;
        bool contB = true;
        public string doubleNeg = "--";
        public string choice = string.Empty;

        public void identifyOp(string input)
        {
            num1 = string.Empty;
            num2 = string.Empty;
            input = input.Trim();
            bool doubleMinus = input.Contains(doubleNeg);


            if (input.Contains("+"))
            {
                var indexOfOp = input.IndexOf('+'); 
                num1 = input.Substring(0, indexOfOp);
                num2 = input.Substring(indexOfOp + 1);
            
                contA = num1.Contains('.');
                if (contA)
                {
                    rational1 = Rational.decimalToRational(num1);
                }
                else
                {
                    rational1 = Rational.Parse(num1);
                }
                contB = num2.Contains('.');
                if (contB)
                {
                    rational2 = Rational.decimalToRational(num2);
                }
                else
                {
                    rational2 = Rational.Parse(num2);
                }                
                sum = Rational.Simplyfy(rational1 + rational2);
                Console.WriteLine(sum);
            }            
            else if (input.Contains("*"))
            {
                var indexOfOp = input.IndexOf('*');
                num1 = input.Substring(0, indexOfOp);
                num2 = input.Substring(indexOfOp + 1);

                contA = num1.Contains('.');
                if (contA)
                {
                    rational1 = Rational.decimalToRational(num1);
                }
                else
                {
                    rational1 = Rational.Parse(num1);
                }
                contB = num2.Contains('.');
                if (contB)
                {
                    rational2 = Rational.decimalToRational(num2);
                }
                else
                {
                    rational2 = Rational.Parse(num2);
                }
                sum = Rational.Simplyfy(rational1 * rational2);
                Console.WriteLine(sum);
                
            }
            else if (input.Contains(":"))
            {
                var indexOfOp = input.IndexOf(':');
                num1 = input.Substring(0, indexOfOp);
                num2 = input.Substring(indexOfOp + 1);

                contA = num1.Contains('.');
                if (contA)
                {
                    rational1 = Rational.decimalToRational(num1);
                }
                else
                {
                    rational1 = Rational.Parse(num1);
                }
                contB = num2.Contains('.');
                if (contB)
                {
                    rational2 = Rational.decimalToRational(num2);
                }
                else
                {
                    rational2 = Rational.Parse(num2);
                }
                sum = Rational.Simplyfy(rational1 / rational2);
                Console.WriteLine(sum);
            }
            else if (input.Contains("-"))
            {
                var indexOfOp = input.IndexOf('-', 1);              
                num1 = input.Substring(0, indexOfOp);
                num2 = input.Substring(indexOfOp + 1);       

                if (input.IndexOf("-", 1) == input.IndexOf("/") + 1)
                {
                    indexOfOp = input.IndexOf("-", '/' + 1);
                }
                else 
                {
                    indexOfOp = input.IndexOf("-", 1);
                } 
                
                num1 = input.Substring(0, indexOfOp);
                num2 = input.Substring(indexOfOp+1);

                contA = num1.Contains('.');
                if (contA)
                {
                    rational1 = Rational.decimalToRational(num1);
                }
                else
                {
                    rational1 = Rational.Parse(num1);
                }
                contB = num2.Contains('.');
                if (contB)
                {
                    rational2 = Rational.decimalToRational(num2);
                }
                else
                {
                    rational2 = Rational.Parse(num2);
                }
                doubleMinus = input.Contains(doubleNeg);
                if (doubleMinus)
                {

                }
                sum = Rational.Simplyfy(rational1 - rational2);
                Console.WriteLine(sum);
            }

            else if (num1 == string.Empty && num2 == string.Empty) 
            {               
                num1 = input;
                
                rational1 = Rational.Parse(num1);

                sum = Rational.Simplyfy(rational1);
                Console.WriteLine(sum);
            }

        }

    }
}
