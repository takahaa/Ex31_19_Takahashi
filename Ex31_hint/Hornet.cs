using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    /// <summary>
    /// 蜂
    /// </summary>
    class Hornet : Character
    {
        public Hornet(string name, float hp, float power, bool animal) : base(name, hp, power, animal) { }
        public override void Attack(Character destination)
        {
            Console.WriteLine($"{this.name}は{destination.name}を毒針で刺した！");
            //相手が動物のとき
            if (destination.animal)
            {
                Console.WriteLine($"{destination.name}は毒が回って即死した！\n");
            }
            else
            {
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}\n");
            }
        }
    }
}
