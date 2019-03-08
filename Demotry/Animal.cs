using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demotry
{
    public abstract class Animal : CanMove
    {
        public void Run()
        {
            Console.WriteLine("Animal Run...");
        }

        public abstract void Back();

    }
}
