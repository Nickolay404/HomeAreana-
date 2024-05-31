namespace ArenaGame.Weapons;

public class ThrowingKnifes : IWeapon
{ 
    public string Name { get; set; }
    private int Knives { get; set; }
    
    public int CountOfThrow { get; set; }
public double AttackDamage { get; set; }
public double BlockingPower { get; set; }
public double SpeedCoef { get; set; }

public ThrowingKnifes(string name, int knives)
{ 
    Name = name;
    Knives = knives;
    AttackDamage = 10;
    BlockingPower = 3;
    CountOfThrow = 0;
    SpeedCoef = 17;
}
public void Throw()
{
    if (Knives > 0)
    {
        Knives--;
        Console.WriteLine("Take this!");
    } 
    if (CountOfThrow % 3 ==0)
    {
        PoisonedKnife();
        Console.WriteLine("Poisoned blades will find you!");
    }
    else if (Knives < 0)
    {
        Console.WriteLine("You're out of knives!");
        RechargeKnives(3);
    }

   
}
public void RechargeKnives(int knivesInPouch)
{
    Knives += knivesInPouch;
    Console.WriteLine($"You recharge your bag{knivesInPouch} with knives.");
}

public void PoisonedKnife()
{
    double knifeWithPoisonDamage = AttackDamage + 3;

}

}