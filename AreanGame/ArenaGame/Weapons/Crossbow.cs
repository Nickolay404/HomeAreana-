namespace ArenaGame.Weapons;

public class Crossbow:IWeapon
{
    public string Name { get; set; }
    public double AttackDamage { get; private set; }

    public double BlockingPower { get; private set; }
    public double SpeedCoef { get; set; }
    public int arrows { get; private set; }
    public double damage { get; private set; }


    
    
    public Crossbow(int arrows, double damage)
    {
        this.arrows = arrows;
        this.AttackDamage = damage;
        this.BlockingPower = 1;
        this.damage = damage;
        this.SpeedCoef = 23;
    }

    public void Shoot()
    {
        if (arrows>0)
        {
            arrows--;
            Console.WriteLine("Farewell, monster!");
        }
        else if (arrows < 0)
        {
            Console.WriteLine("Looks like I'm out of arrows");
            Recharge(3);
            
        }
    }

    public void Recharge(int ArrowsInQuiver)
    {
        arrows += ArrowsInQuiver;
        Console.WriteLine("Don't think you've won yet!");
    }

   
}