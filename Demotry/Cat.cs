using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demotry
{
    public class Cat : Animal, CanDrink, CanEat
    {
        private string name;

        public Cat(string name)
        {
            this.name = name;
        }

        public string GetNameCat()
        {
            return this.name;
        }
        public void Drink()
        {
            Console.WriteLine(name+ " drinking...");
        }

        public void Eat()
        {
            Console.WriteLine(name + " eating...");
        }

        public override void Back()
        {
            Console.WriteLine("Cat back...");
        }
    }
}
