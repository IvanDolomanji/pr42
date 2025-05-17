using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_10_vr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество мест в детском саду: ");
            int capacity = int.Parse(Console.ReadLine());

            PlaySchool school = new PlaySchool(capacity);
            Manageress manager = new Manageress();
            Department department = new Department();

            // Подписки на события
            school.NotPlaces += manager.Queue;
            manager.Zapys += department.Place;

            Console.Write("Введите количество детей: ");
            int totalChildren = int.Parse(Console.ReadLine());

            for (int i = 1; i <= totalChildren; i++)
            {
                Child child = new Child(i);
                school.PushChild(child);
            }

            Console.WriteLine("\nОбработка завершена.");

            Console.ReadKey();
        }
    }

}

