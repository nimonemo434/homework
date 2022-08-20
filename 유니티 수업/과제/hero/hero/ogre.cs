using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hero
{
    internal class ogre : Lifesystem
    {
        public override void Init()
        {
            Hp = 300;
            name = "오거";
            attackDamage = 50;
        }
    }
}
