﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class Car :IMovable
    {
        public double Speed { get; set; }

        public void Move()
        {
            Console.WriteLine($"Car has Speed {Speed}");
        }
    }
}
