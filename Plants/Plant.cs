using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plants
{
    internal abstract class Plant
    {
        internal string Name;
        public Plant(string name)
        {
            Name = name;    
        }
        internal abstract void Grow();
    }
}
