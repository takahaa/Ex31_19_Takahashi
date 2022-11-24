using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    /// <summary>
    /// 牛
    /// </summary>
    class Cow : Character
    {

        public Cow(string name, float hp, float power, bool animal) : base(name, hp, power, animal) { }
        public override void Attack(Character destination)
        {
            if (this.hp >= 5)
            {
                Console.WriteLine($"{this.name}は{destination.name}を角で突いた！");
                Console.WriteLine($"{destination.name}はうしろに吹っ飛んだ！");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}\n");
            }
            else
            {
                Console.WriteLine($"{base.name}は体力不足です！\n");
            }
        }

    }
}
