using Inlämning1;
using System.Data.Common;
using System.Runtime.CompilerServices;
System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;


var num1 = string.Empty;
var num2 = string.Empty;
var rational1 = new Rational(int.MinValue, int.MaxValue);
var rational2 = new Rational(1,1);
var sum = new Rational(int.MinValue, int.MaxValue);
var calcu = new Calcu();

Console.WriteLine("Hej, här är din Calculater.");
var input = "";

while(input != "quit")
{
    input = Console.ReadLine().ToLower().Trim();
    
    try
    {
        if (input == "quit")
        {
            break;
        }
        else
        {
            calcu.identifyOp(input);
        }
    }

    catch (DivideByZeroException)
    {
        Console.WriteLine("Division by zero is undefined");
    }
    catch (Exception)
    {
        Console.WriteLine("Syntax Error");
    }


}
