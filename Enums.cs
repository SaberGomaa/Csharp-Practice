using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    enum Grade : short
    {
        Excelent = 0,
        VeryGood = 1,
        Good = 2,
        Pass = 3,
    }

    [Flags]
    enum Color
    {
        Red = 3,
        Green = 2,
        Blue = 5,
    }
}
