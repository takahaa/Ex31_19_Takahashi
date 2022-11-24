using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    //Characterから派生
    /// <summary>
    /// タンク
    /// </summary>
    class Tank : Character
    {
        //砲弾
        public int bullet = 0;
        public Tank(string name, float hp, float power,bool animal ) : base(name, hp, power, animal) { }
        public override void Attack(Character destination)
        {
            if (bullet > 0)
            {
                bullet--;
                Console.WriteLine($"{this.name}は{destination.name}に向け大砲を発射！");
                Console.WriteLine($"{destination.name}に砲弾が直撃！");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}\n");
            }
            else
            {
                Console.WriteLine($"{base.name}は弾切れです！\n");
            }
        }
    }
}
