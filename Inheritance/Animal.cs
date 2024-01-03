using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public Animal() 
        {
        }
        public int Legs {  get; set; }
        public bool Eats { get; set; }
        public bool Reproduces { get; set; }
        public int LifeSpan { get; set; }
    

    }
}
