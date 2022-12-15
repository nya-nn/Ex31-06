using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31_06
{
    internal class Tank:Character
    {
        public int bullet;
        public Tank(string name,float hp,float power,bool resistance,int bullet) : base(name, hp, power,resistance)
        {
            this.bullet = bullet;
        }
        public override void Attack(Character destination)
        {
            if (bullet > 0)
            {
                bullet--;
                Console.WriteLine($"{this.name}→{destination.name}");
                Console.WriteLine($"{destination.name}へ{this.power}ダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}のHPは{destination.hp}");
                Console.WriteLine($"{this.name}の残弾は{this.bullet}");
            }
            else
            {
                Console.WriteLine($"{this.name}は弾切れです");
            }
        }
    }
}
