using System.Security.Cryptography.X509Certificates;

namespace _2._2Uzduotis_Out
{
    public class Program
    {
        public static void Main(string[] args)
        {
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        bool success = Divide(num1, num2, out double result);

            if (success)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Nepavyko padalinti");
            }
        }
        public static bool Divide(double num1, double num2, out double result)
        {
            result = num1 / num2;

            if (num2 == 0)
            {
                return false;

            }
            return true;
        }
    }
}