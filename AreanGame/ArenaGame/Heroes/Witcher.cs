namespace ArenaGame.Heroes
{

    public class Witcher : Hero
    {
       public double MarkYrden;
        public  double  MarkIgni;
        public double MarkAard;
        public double MarkForceFieldQuen;
        
       

        public Witcher(string name, double armor, double strenght, IWeapon weapon, double health) : base(name, armor,
            strenght, weapon, health)
        {
            Armor = 1;
            MarkYrden= 2;
            MarkIgni = 1;
            MarkForceFieldQuen = 2;
            MarkAard = 2;
        }
        
        public override double Attack()
        { 
            double spellDamage = CastIgniMark();
            double weaponDamage = base.Attack();
            return weaponDamage + spellDamage;

        }

        public override double Defend(double damage)
        {
            if (MarkForceFieldQuen > 0 )
            {
                double ADamage = Math.Min(damage, MarkForceFieldQuen);
                MarkForceFieldQuen -= ADamage;
                damage -= ADamage;

                if (damage<=0)
                {
                    return 0;
                }
            }
            if (MarkYrden> 0)
            {
                damage *= 0.5;
                MarkYrden--;
            }
            SignAttack();
            return base.Defend(damage);

        }
        public double CastIgniMark()
        {
            return Strenght *  1.2;
        }

        public void CastQuenMark()
        {
            MarkForceFieldQuen = 3;
            Console.WriteLine($"Quen is activated with power {MarkForceFieldQuen}");
        }
        public void CastTheYrdenMark()
        {
            if (MarkYrden< 5)
            {
                MarkYrden++;
                Armor += 1;
            }
        }

        public double CastTheAardMark()
        {
            if (MarkAard > 1)
            {
                double AardDamage = 5;
                return AardDamage;

            }
            return 0;
        }

        public void SignAttack()
        {
            int sign = random.Next(1, 4);
            switch (sign)
            { case 1:
                Console.WriteLine("....Wither use Igni...");
                CastIgniMark();
                break;
            case 2:
                Console.WriteLine(".....Wither use Force field......");
                CastQuenMark();
                break;
            
            case 3:
                Console.WriteLine(".....Wither use Yrden........");
                CastTheYrdenMark();
                break; 
            case 4:
                Console.WriteLine(".....Wither use Aard........");
                CastTheAardMark();
                break;
            }
        }
        
        
    }
}