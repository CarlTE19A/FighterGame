using System;

namespace FighterSim
{
    class Fighter
    {
        public string name;
        public int hp;
        public Weapon weapon = new Weapon();
        public Fighter(string _name, int _hp)
        {
            name = _name;
            hp = _hp;
        }
        
        public void TakeDamage(int damage)
        {
            hp -= damage;
        }
        public int GiveDamage()
        {
            return(weapon.RandomDamge());
        }
        
    }
}
