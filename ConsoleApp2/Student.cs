using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Student
    {
        public string Name { get; }

        public Student(string name)
        {
            Name = name;
        }

        public void OnLessonStart()
        {
            Console.WriteLine($"Ученик {Name} идет на урок");
        }

        public void OnLessonEnd()
        {
            Console.WriteLine($"Ученик {Name} идет на перемену");
        }
    }
}
