using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class Human : IMovable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }

        public void Move()
        {
            Console.WriteLine($"Human has Speed {Speed}");
        }
    }
}
