using System;

namespace Ex31_hint
{
    class Program
    {
        static void Main(string[] args)
        {
            //インスタンス
            Character character1 = new Character("しむら人", 500, 2, true);
            Character character2 = new Character("ささっき", 1000, 25, true);
            Cow cow = new Cow("牛", 1500, 30, true);
            Cat cat = new Cat("猫", 300, 10, true);
            Hornet hornetcs = new Hornet("蜂", 100, 35, true);
            Tank tank1 = new Tank("Tiger", 500000, 250, false);
            tank1.bullet = 10;
            Tank tank2 = new Tank("がんタンク", 10000, 125, false);
            tank2.bullet = 5;
            Character[] characters = { cat, character2, cow, character1 , tank1, tank2, hornetcs };
            //iを１からにすると、0のキャラクターが重複しない
            for(var i = 1; i < characters.Length; i++)
            {
                characters[i].Attack(cat);
            }
        }
    }
}
