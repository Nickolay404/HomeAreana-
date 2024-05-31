namespace ArenaGame.Weapons;

public class Rapier:IWeapon
{
    public string Name { get; set; }
    public double AttackDamage { get; private set; }

    public double BlockingPower { get; private set; }
    
    public static Random random= new Random();
    public double SpeedCoef { get; set; }

    public Rapier(string name)
    {
        Name = name;
        AttackDamage = 15;
        BlockingPower = 5;
        SpeedCoef = 10;
    }

    public void Lunge()
    {
        double additionalDamage = random.Next(1, 31); 
        AttackDamage += additionalDamage;
    }

   

}