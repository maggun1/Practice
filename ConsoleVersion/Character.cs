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
        private int actionPoints;
        private int noDamageChance;
        private int armor;
        private int maxHealth;
        public int Health { get => health; set => health = value; }
        public int ActionPoints { get => actionPoints; set => actionPoints = value; }
        public int Armor
        {
            get => armor;
            set 
            {
                if (value == 0)
                    armor = 1;
            }
        }
        public int NoDamageChance { get => noDamageChance; set => noDamageChance = value; }
        public Character(string name, int health, int actionPoints, int noDamageChance, int armor)
        {
            this.name = name;
            this.health = health;
            this.actionPoints = actionPoints;
            this.noDamageChance = noDamageChance;
            this.armor = armor;
            maxHealth = health;
        }
        public void Hit(Character enemy, Weapon weapon)
        {
            Random random = new Random();
            if (random.Next(enemy.NoDamageChance) == 0)
            {
                enemy.Health = enemy.Health - weapon.Damage * 1 / this.Armor;
                this.ActionPoints = ActionPoints - weapon.ConsumptionOfActionPoints;
            }
            else
                throw new Exception($"{name} промахнулся!");
        }
        public void Heal() => health = maxHealth;
    }
}
