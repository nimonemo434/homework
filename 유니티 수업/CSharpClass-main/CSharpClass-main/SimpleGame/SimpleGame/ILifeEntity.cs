using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    interface ILifeEntity
    {
        void Attack(LifeEntity lifeEntity);
        void Hit(int attakDamage);
    }
}
