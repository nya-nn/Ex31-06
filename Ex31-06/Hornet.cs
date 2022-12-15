using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31_06
{
    internal class Hornet:Character
    {
        public Hornet(string name,float hp,float power,bool resistance) : base(name, hp, power, resistance) { }
        public override void Attack(Character destination)
        {
            Console.WriteLine($"{this.name}→{destination.name}");
            if (destination.resistance == true)
            {
                Console.WriteLine($"{destination.name}に毒は効かない");
                Console.WriteLine($"{destination.name}は{this.power}ダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}のHPは{destination.hp}");
            }
            else
            {
                Console.WriteLine($"{destination.name}は毒が回って即死");
                destination.hp = 0;
            }
        }
    }
}
