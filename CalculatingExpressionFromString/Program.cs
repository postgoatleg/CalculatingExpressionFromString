
using System.Linq;
using System.Text.RegularExpressions;
using ExpressionAnalayzer;

Console.WriteLine("Введите формулу:");
string? str = Console.ReadLine();

if(str != null && ExpressionAnalayzerClass.IsMeaningfulExpression(str))
{
    Console.WriteLine("Enter var value");
    double x = Convert.ToDouble(Console.ReadLine());
    string[] strArr = ExpressionAnalayzerClass.ConvertToStringArray(str);
    Console.WriteLine($"result ={ExpressionAnalayzerClass.GetAnswer(strArr[2], ExpressionAnalayzerClass.getFunc(strArr[1], x), ExpressionAnalayzerClass.getFunc(strArr[3], x))}");
    
}
else
{
    Console.WriteLine("Введено неверное выражение");
}
Console.ReadLine();