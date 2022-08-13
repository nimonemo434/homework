using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    class Monster : LifeEntity
    {
        public override void Init()
        {
            Hp = 50;
            name = "몬스터";
            attackDamage = 3;
        }
    }
}
