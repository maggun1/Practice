using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleVersion
{
    internal class Weapon
    {
        private string name;
        private int damage;
        private int consumptionOfActionPoints;
        public string Name { get => name; }
        public int Damage { get => damage; }
        public int ConsumptionOfActionPoints { get => consumptionOfActionPoints; }
    }
}
