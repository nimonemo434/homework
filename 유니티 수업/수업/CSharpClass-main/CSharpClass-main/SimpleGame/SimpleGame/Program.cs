using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            MainCharacter mainCharacter = new MainCharacter();
            mainCharacter.Init();
            
            Zombie zombie = new Zombie(); 
            zombie.Init();

            Ghost ghost = new Ghost();
            ghost.Init();


            mainCharacter.Attack(zombie);
            Console.WriteLine();

            zombie.Attack(mainCharacter);
            Console.WriteLine();

            ghost.Attack(mainCharacter);
            Console.WriteLine();


            System.Console.ReadKey();
        }
    }
}
