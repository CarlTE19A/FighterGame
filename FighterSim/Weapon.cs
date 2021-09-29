using System;
using System.Numerics;

namespace FighterSim
{
    class Weapon
    {
        public string name;
        private Vector2 damage;
        private Random generator = new Random();
        public Weapon()
        {
            int tempRandom = generator.Next(0, Weapons.weaponNames.Length);
            name = Weapons.weaponNames[tempRandom];
            damage = Weapons.weaponsDamage[tempRandom];
        }
        public int RandomDamge()
        {
            return
            (
                generator.Next((int)damage.X, (int)damage.Y + 1)
            );
        }
    }
}
