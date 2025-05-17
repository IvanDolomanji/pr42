using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Teacher
    {
        public string Name { get; }

        public Teacher(string name)
        {
            Name = name;
        }

        public void OnLessonStart()
        {
            Console.WriteLine($"Учитель {Name} идет на урок");
        }

        public void OnLessonEnd()
        {
            Console.WriteLine($"Учитель {Name} идет в учительскую");
        }
    }
}
