using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public static class Settings
    {
        private static readonly string _configFilePath;

        static Settings()
        {
            _configFilePath = @"C:\ProgramData\MyApp\config.xml";
            Console.WriteLine("Статический конструктор Settings выполнен.");
        }

        public static void DisplayConfigPath()
        {
            Console.WriteLine($"Путь к файлу конфигурации: {_configFilePath}");
        }
    }
}
