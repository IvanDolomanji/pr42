using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_10_vr
{
    internal class Manageress
    {
        public event Action Zapys;

        public void Queue()
        {
            Console.WriteLine("Мест нет! Предлагаю встать в очередь.");
            Zapys?.Invoke();
        }
    }
}
