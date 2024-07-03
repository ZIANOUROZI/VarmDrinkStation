using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarmDrinkStation
{
    internal class Tea :IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Enjoy your cup of tea");
        }
    }
}
