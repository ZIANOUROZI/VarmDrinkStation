using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarmDrinkStation
{
    internal class VarmDrinkStation :IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Steep tea bag in {total} ml of hot water.");
            return new Tea();
        }
    }
}
