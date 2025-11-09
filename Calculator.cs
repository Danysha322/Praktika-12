using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public static class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Subtract(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static string Divide(double a, double b)
        {
            if (b == 0)
            {
                return "Ошибка: Деление на ноль!";
            }
            return (a / b).ToString();
        }
    }
}
