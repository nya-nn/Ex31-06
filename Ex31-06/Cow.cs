using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31_06
{
    internal class Cow:Character
    {
        public Cow(string name, float hp, float power,bool resistance) : base(name, hp, power,resistance) { }
        public override void Attack(Character destination)
        {
            if (this.hp > 5)
            {
                Console.WriteLine($"{this.name}→{destination.name}");
                Console.WriteLine($"{destination.name}へ{this.power}ダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}のHPは{destination.hp}");
            }
            else
            {
                Console.WriteLine($"{this.name}は元気がありません");
            }
        }
    }
}
