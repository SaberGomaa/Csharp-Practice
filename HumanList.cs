using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class HumanList : List<Human>
    {
        public new void Add(Human h)
        {
            if (h.Speed > 150)
                base.Add(h);
            else
                throw new Exception("Speed Must Greater Than 150");
        }
    }
}
