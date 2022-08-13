using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    class MainCharacter : LifeEntity
    {
        public override void Init()
        {
            Hp = 100;
            name = "메인 캐릭터";
            attackDamage = 10;
        }
    }
}
