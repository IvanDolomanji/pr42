using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Barrier barrier = new Barrier();
            Random random = new Random();

            Barrier.Event1 += () => { };
            Barrier.Event2 += () => { };

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Введите имя человека:");
                string name = Console.ReadLine();

                Man man = new Man(name);

                Barrier.Event1 += man.Go;
                Barrier.Event2 -= man.Stop;

                barrier.TriggerEvent(random);

                Console.WriteLine();

            }
            Console.WriteLine("Проход людей завершен");
            Console.ReadKey();
        }
    }
}

