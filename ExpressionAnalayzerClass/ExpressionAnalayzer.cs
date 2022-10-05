using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace ExpressionAnalayzer
{
    public class ExpressionAnalayzerClass
    {
        static Regex fillRx = new Regex(@"(cos|sin|tg|ctg)");
        static private readonly Regex rx = new Regex(@"[a-z]\([a-z]\)\=(sin|cos|tg|ctg)\([a-z]\)[\+\-\*](sin|cos|tg|ctg)\([a-z]\)");
        static Regex replaceRx = new Regex(@"\([a-z]\)");

        public static bool IsMeaningfulExpression(string? str)
        {
            return rx.IsMatch(str);
        }

        public static string[] ConvertToStringArray(string str)
        {
            str = replaceRx.Replace(str, "");
            return fillRx.Split(str);
        }
        public static double GetAnswer(string mathOperator, double x, double y)
        {
            switch (mathOperator)
            {
                case "-":
                    return x - y;
                case "+":
                    return x + y;
                case "*":
                    return x * y;
                case null:
                    return 0;
            }
            return 0;
        }
        public static double getFunc(string strFunc, double x)
        {

            switch (strFunc)
            {
                case "cos":
                    return Math.Cos(x);
                case "sin":
                    return Math.Sin(x);
                case "tg":
                    return Math.Tan(x);
                case "ctg":
                    return 1 / Math.Tan(x);
            }
            return 0;
        }
    }
}