using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleVersion
{
    internal class Character
    {
        private string name;
        private int health;
        private int armor;
        private int maxHealth;
        public int Health { get => health; set => health = value; }
        public int Armor
        {
            get => armor;
            set
            {
                if (value == 0)
                    armor = 1;
            }
        }
        public Character(string name, int health, int actionPoints, int armor)
        {
            this.name = name;
            this.health = health;
            this.armor = armor;
            maxHealth = health;
        }
        public void Hit(Character enemy, Weapon weapon)
        {
            Random random = new Random();
            if (random.Next(10) != 0)
            {
                enemy.Health = enemy.Health - weapon.Damage * 1 / this.Armor;
            }
            else
                throw new Exception($"{name} промахнулся!");
        }
        public void Heal() => health = maxHealth;
    }
}
