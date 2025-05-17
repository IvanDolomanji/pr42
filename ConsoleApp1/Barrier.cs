using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Barrier
    {
        public static event Action Event1;
        public static event Action Event2;

        public void TriggerEvent(Random random)
        {
            int number = random.Next(1, 3);

            if (number == 1)
            {
                Console.WriteLine("Шлагбаум: Открыто");
                Event1?.Invoke();
            }
            else
            {
                Console.WriteLine("Шлагбаум: Закрыто");
                Event2?.Invoke();
            }
        }
    }
}
