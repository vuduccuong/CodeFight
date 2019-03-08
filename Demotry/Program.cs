using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demotry
{
    class Program
    {
        static void Main()
        {
            CanEat canEat = new Cat("Tom");
            canEat.Eat();
            
            CanDrink canDrink = new Cat("Tam the");
            canDrink.Drink();
            Console.ReadLine();
        }
    }
}
