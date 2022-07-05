using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsVersion
{
    public class Weapon
    {
        private string name;
        private int damage;
        public string Name { get => name; }
        public int Damage { get => damage; }
        public Weapon(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }
    }
}
