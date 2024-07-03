using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarmDrinkStation
{
    internal class Water :IWarmDrink
    {
         public void Consume()
        {
            Console.WriteLine("War water is served");
        }
    }
}
