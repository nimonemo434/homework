using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hero
{
    internal class wolf : Lifesystem
    {
        public override void Init()
        {
            Hp = 100;
            name = "늑대";
            attackDamage = 20;
        }
    }
}
