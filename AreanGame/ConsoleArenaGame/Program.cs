using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;

namespace ConsoleArenaGame
{
    class Program
    {
        static void ConsoleNotification(GameEngine.NotificationArgs args)
        {
            Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack,2)} and caused {Math.Round(args.Damage,2)} damage.");
            Console.WriteLine($"Attacker: {args.Attacker}");
            Console.WriteLine($"Defender: {args.Defender}");
        }
        static void Main(string[] args)
        {
            GameEngine gameEngine = new GameEngine()
            {
              
                HeroA = new Witcher("Gerold", 3, 1, new ThrowingKnifes("Knife", 6), 100),
                HeroB = new Mutant("Rosman", 3, 12, new Crossbow(4,17),100),
           
                NotificationsCallBack = ConsoleNotification
                
                
               
            };

            gameEngine.Fight();
       
            Console.WriteLine();
            Console.WriteLine($"And the winner is {gameEngine.Winner}");
        }
    }
}