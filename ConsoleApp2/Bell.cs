using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Bell
    {
        public int LessonNumber { get; set; }

        public Bell(int number)
        {
            LessonNumber = number;
        }

        public event Action Event1; // Звонок на урок
        public event Action Event2; // Звонок с урока

        public void Ring()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Звонок на {LessonNumber} урок");
            Console.ResetColor();
            Event1?.Invoke();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Звонок с {LessonNumber} урока");
            Console.ResetColor();
            Event2?.Invoke();
        }
    }
}
