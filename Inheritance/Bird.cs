using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Legs = 2;
            Eats = true;
            Reproduces = true;
            LifeSpan = 0;

        }
        public bool HasFeathers { get; set; }
        public bool Migrates { get; set; }
        public bool CanFly { get; set; }
        public string Color { get; set; }

    }
        
}
