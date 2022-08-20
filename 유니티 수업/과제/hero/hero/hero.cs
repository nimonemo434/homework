using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hero
{
    internal class hero : Lifesystem
    {
        public override void Init()
        {
            Hp = 200;
            name = "영웅";
            attackDamage = 50;
        }
    }
}
