using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    struct Complex
    {
        public Complex(int id, string name = "sa")
        {
            Id = id;
            Name = name;
        }
        public Complex(int id)
        {
            Id = id;
            Name = "Default";
        }
        
        public int Id;
        public string Name;
    }
}
