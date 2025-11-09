using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1: Класс Calculator");
            Console.WriteLine($"10 + 5 = {Calculator.Add(10, 5)}");
            Console.WriteLine($"10 - 5 = {Calculator.Subtract(10, 5)}");
            Console.WriteLine($"10 * 5 = {Calculator.Multiply(10, 5)}");
            Console.WriteLine($"10 / 5 = {Calculator.Divide(10, 5)}");
            Console.WriteLine($"10 / 0 = {Calculator.Divide(10, 0)}");
            Console.WriteLine();

            Console.WriteLine("Задание 2: Класс ProgramConfig");
            ProgramConfig.DisplayProgramInfo();
            Console.WriteLine();

            Console.WriteLine("Задание 3: Класс ObjectCounter");
            ObjectCounter.DisplayCount();

            ObjectCounter obj1 = new ObjectCounter();
            ObjectCounter obj2 = new ObjectCounter();
            ObjectCounter obj3 = new ObjectCounter();

            ObjectCounter.DisplayCount();

            ObjectCounter obj4 = new ObjectCounter();
            ObjectCounter.DisplayCount();
            Console.WriteLine();

            Console.WriteLine("Задание 4: Класс Book");
            Book book1 = new Book("978-5-699-12014-7", "Война и мир", "Лев Толстой");
            Book book2 = new Book("978-5-17-145907-4", "Преступление и наказание", "Фёдор Достоевский");

            book1.DisplayBookInfo();
            book2.DisplayBookInfo();

            Console.WriteLine();

            Console.WriteLine("Задание 5: Класс Settings");
            Settings.DisplayConfigPath();

            Console.WriteLine("\nНажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}