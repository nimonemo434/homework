using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    class LifeEntity : ILifeEntity
    {
        protected int Hp;
        public string name;
        protected int attackDamage;

        public virtual void Init()
        {

        }

        public void Attack(LifeEntity lifeEntity)
        {
            System.Console.WriteLine(name + " : " + lifeEntity.name + "을(를) 공격했습니다");

            lifeEntity.Hit(attackDamage);
        }

        public void Hit(int _attackDamage)
        {
            Hp -= _attackDamage;

            System.Console.WriteLine(name + " : " + "공격 당했습니다");
            System.Console.WriteLine(name + " : " + "체력은 " + Hp + "만큼 남았습니다");

        }
    }
}
