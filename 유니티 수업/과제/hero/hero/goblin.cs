using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hero
{
    internal class goblin : Lifesystem
    {
        public override void Init()
        {
            Hp = 50;
            name = "고블린";
            attackDamage = 10;
        }
    }
}
