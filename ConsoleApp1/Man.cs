using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Man
    {
        public string Name;

        public Man(string name)
        {
            Name = name;
        }
        public void Go()
        {
            Console.WriteLine($"{Name}:Иду");

            Barrier.Event1 -= Go;
            Barrier.Event2 -= Stop;
        }
        public void Stop()
        {
            Console.WriteLine($"{Name}");
        }
    }
}
