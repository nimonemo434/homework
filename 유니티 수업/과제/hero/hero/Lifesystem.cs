using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hero
{
    internal class Lifesystem
    {
        public int Hp;
        public string name;
        public int attackDamage;

        public virtual void Init()
        {

        }
        public void Attack(Lifesystem lifesystem)
        {
            WriteLine(name + " : " + lifesystem.name + "을(를) 공격했습니다");

            lifesystem.Hit(attackDamage);
        }
        public void CriticalAttack(Lifesystem lifesystem)
        {
            WriteLine(name + " : " + lifesystem.name + "을(를) 공격했습니다");

            lifesystem.Critical(attackDamage);
        }
        public void Hit(int _attackDamage)
        {
            Hp -= _attackDamage;

            WriteLine(name + " : " + "공격 당했습니다");
            WriteLine(name + " : " + "체력이 " + Hp + "만큼 남았습니다");
        }
        public void Critical(int _attackDamage)
        {
            Hp -= _attackDamage * 2;

            WriteLine(name + " : " + "공격 당했습니다");
            WriteLine(name + " : " + "치명타 입니다");
            WriteLine(name + " : " + "체력이 " + Hp + "만큼 남았습니다");
        }
    }
}
