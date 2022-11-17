using System;

namespace Ex31_hint
{
    class Program
    {
        static void Main(string[] args)
        {
            //インスタンス
            Character character1 = new Character("しむら人", 500, 2);
            Character character2 = new Character("ささっき", 1000, 25);
            Cow cow = new Cow("牛", 1500, 30);
            Cat cat = new Cat("猫", 300, 10);
            Tank tank1 = new Tank("Tiger", 500000, 250);
            tank1.bullet = 10;
            Tank tank2 = new Tank("がんタンク", 10000, 125);
            tank2.bullet = 5;
            Character[] characters = { cat, character2, cow, character1 , tank1, tank2 };
            //iを１からにすると、0のキャラクターが重複しない
            for(var i = 1; i < characters.Length; i++)
            {
                characters[i].Attack(cat);
            }
        }
    }
}
