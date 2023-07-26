using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class Creature
    {
        public int Weight;
        public int Height;

        public Creature()
        {
            Weight = 10;
            Height = 10;
        }

        public Creature(int h , int w)
        {
            Weight = w;
            Height = h;
        }

        public virtual void Move()
        {
            Console.WriteLine("Creature is move .. ");
        }

        public void Eat()
        {
            Console.WriteLine("Creature is eat .. ");
        }
    }
}
