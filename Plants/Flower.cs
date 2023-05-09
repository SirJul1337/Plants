using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plants
{
    internal class Flower : Plant
    {
        public string Color { get; private set; }
        public Flower(string name, string color):base(name)
        {
            Color = color;
        }
        internal override void Grow()
        {
            Console.WriteLine($"{GetType().Name} | {this.Name} Grows, Color is {this.Color} ");
        }
    }
}
