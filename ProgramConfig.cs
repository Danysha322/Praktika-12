using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public static class ProgramConfig
    {
        private const string VERSION = "1.0.0";
        private const string DEVELOPER = "ООО 'Разработка ПО'";

        public static void DisplayProgramInfo()
        {
            Console.WriteLine($"Версия программы: {VERSION}");
            Console.WriteLine($"Разработчик: {DEVELOPER}");
        }
    }
}
