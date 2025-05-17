using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество уроков: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите имя учителя: ");
            string teacherName = Console.ReadLine();
            Teacher teacher = new Teacher(teacherName);

            Console.Write("Введите имя ученика: ");
            string studentName = Console.ReadLine();
            Student student = new Student(studentName);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nУрок №{i}:");

                Bell bell = new Bell(i);

                // Подписка
                bell.Event1 += teacher.OnLessonStart;
                bell.Event1 += student.OnLessonStart;

                bell.Event2 += teacher.OnLessonEnd;
                bell.Event2 += student.OnLessonEnd;

                // Генерация событий
                bell.Ring();
            }

            Console.WriteLine("\nВсе уроки закончились.");
        }
    }
    }

