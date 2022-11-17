using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    class Cow : Character
    {

        public Cow(string name, float hp, float power) : base(name, hp, power) { }
        public override void Attack(Character destination)
        {
            if (this.hp >= 5)
            {
                Console.WriteLine($"{this.name}は{destination.name}を角で突いた！");
                Console.WriteLine($"{destination.name}はうしろに吹っ飛んだ！");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
            }
            else
            {
                Console.WriteLine($"{base.name}は体力不足です！");
            }
        }

    }
}
