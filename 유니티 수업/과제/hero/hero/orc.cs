using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hero
{
    internal class orc : Lifesystem
    {
        public override void Init()
        {
            Hp = 150;
            name = "오크";
            attackDamage = 30;
        }
    }
}
