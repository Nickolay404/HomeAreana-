using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public abstract class Hero : IHero
    {
        protected Random random = new Random();
        public string Name { get;  set; }
        public double Health { get; set; }
        public double Armor { get; set; }
        public double Strenght { get; set; }
        public IWeapon Weapon { get;  set; }
        public bool IsAlive
        {
            get
            {
                return Health > 0;
            }
        }

        public Hero(string name, double armor, double strenght, IWeapon weapon, double health)
        {
            Health = health;

            Name = name;
            Armor = armor;
            Strenght = strenght;
            Weapon = weapon;
        }


        // returns actual damage
        public virtual double Attack()
        {
            return Weapon.AttackDamage;
        }

        public virtual double Defend(double damage)
        {
            double coef = random.Next(80, 120 + 1);
            double defendPower = (Armor + Weapon.BlockingPower) * (coef / 100);
            double realDamage = damage - defendPower;
            if (realDamage < 0)
                realDamage = 0;
            Health -= realDamage;
            return realDamage;
        }

        public override string ToString()
        {
            return $"{Name} with health {Math.Round(Health,2)}";
        }
    }
}
