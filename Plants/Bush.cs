using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plants
{
    internal class Bush:Plant
    {
        public double Length { get; private set; }
        public Bush(string name, double length):base(name)
        {
            Length = length;
        }
        internal override void Grow()
        {
            Console.WriteLine($"{GetType().Name} | {this.Name} Grows, length is now {this.Length} meter");
        }
    }
}
