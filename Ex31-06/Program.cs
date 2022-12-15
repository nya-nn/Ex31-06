using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31_06
{
    internal class Program
    {

        static void Main()
        {
            Character character1 = new Character("実験体", 100000, 6, false);
            Character character2 = new Character("モブB", 25, 8, false);
            Tank tank1 = new Tank("戦車A", 1000, 100, true, 2);
            Tank tank2 = new Tank("戦車B", 500, 75, true, 0);
            Cat cat1 = new Cat("猫A", 15, 20, false);
            Cat cat2 = new Cat("猫B", 20, 10, false);
            Cow cow1 = new Cow("牛A", 100, 20, false);
            Cow cow2 = new Cow("牛B", 5, 15, false);
            Hornet hornet = new Hornet("蜂", 5, 3, false);

            Character[] characters = { character1, character2, tank1, tank2, cat1, cat2,cow1,cow2, hornet};

            for (var i = 1; i < characters.Length; i++)
            {
                characters[i].Attack(character1);
                Console.WriteLine(" ");
            }
            hornet.Attack(tank1);
            hornet.Attack(cat1);
            hornet.Attack(cow1);
        }
    }
}
