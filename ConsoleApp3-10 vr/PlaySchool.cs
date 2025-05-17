using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_10_vr
{
    internal class PlaySchool
    {
        private int capacity;
        private int currentCount = 0;

        public PlaySchool(int capacity)
        {
            this.capacity = capacity;
        }

        public event Action NotPlaces;

        public void PushChild(Child child)
        {
            if (currentCount < capacity)
            {
                currentCount++;
                Console.WriteLine($"Ребенок {child.Number} зачислен.");
            }
            else
            {
                NotPlaces?.Invoke();
            }
        }
    }
}
