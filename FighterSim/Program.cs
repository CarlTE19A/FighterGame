using System;

namespace FighterSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int standardPlayerLife = 100;
            int standardEnemyLife = 100;
            
            Fighter player = NewPlayer();
            Fighter enemy = NewEnemy();
            if(player.name == "Martin")
            {
                System.Console.WriteLine(@"
 ___ ___   ____  ____  ______  ____  ____        _____ ____  ___ ___  __ __  _       ____  ______   ___   ____  
|   |   | /    ||    \|      ||    ||    \      / ___/|    ||   |   ||  |  || |     /    ||      | /   \ |    \ 
| _   _ ||  o  ||  D  )      | |  | |  _  |    (   \_  |  | | _   _ ||  |  || |    |  o  ||      ||     ||  D  )
|  \_/  ||     ||    /|_|  |_| |  | |  |  |     \__  | |  | |  \_/  ||  |  || |___ |     ||_|  |_||  O  ||    / 
|   |   ||  _  ||    \  |  |   |  | |  |  |     /  \ | |  | |   |   ||  :  ||     ||  _  |  |  |  |     ||    \ 
|   |   ||  |  ||  .  \ |  |   |  | |  |  |     \    | |  | |   |   ||     ||     ||  |  |  |  |  |     ||  .  \
|___|___||__|__||__|\_| |__|  |____||__|__|      \___||____||___|___| \__,_||_____||__|__|  |__|   \___/ |__|\_|
"
                );
            }
            else{
                System.Console.WriteLine(
                    "░█████╗░██████╗░██████╗░░█████╗░  ░██████╗██╗███╗░░░███╗██╗░░░██╗██╗░░░░░░█████╗░████████╗░█████╗░██████╗░\n" +
                    "██╔══██╗██╔══██╗██╔══██╗██╔══██╗  ██╔════╝██║████╗░████║██║░░░██║██║░░░░░██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗\n" +
                    "███████║██████╔╝██║░░██║███████║  ╚█████╗░██║██╔████╔██║██║░░░██║██║░░░░░███████║░░░██║░░░██║░░██║██████╔╝\n" +
                    "██╔══██║██╔══██╗██║░░██║██╔══██║  ░╚═══██╗██║██║╚██╔╝██║██║░░░██║██║░░░░░██╔══██║░░░██║░░░██║░░██║██╔══██╗\n" +
                    "██║░░██║██║░░██║██████╔╝██║░░██║  ██████╔╝██║██║░╚═╝░██║╚██████╔╝███████╗██║░░██║░░░██║░░░╚█████╔╝██║░░██║\n" +
                    "╚═╝░░╚═╝╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝  ╚═════╝░╚═╝╚═╝░░░░░╚═╝░╚═════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝\n"
                );
            }
            
            GameLoop();

            
            void NewFight()
            {
                System.Console.WriteLine($"Eyy dehär är dålig korv {player.name}");
                System.Console.WriteLine($"Jag är {enemy.name} och vill slås");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Du har {player.weapon.name}, din fiende har {enemy.weapon.name}");
            }
            void GameLoop()
            {
                NewFight();
                bool gameLoop = true;
                while(gameLoop == true)
                {
                    player.TakeDamage(enemy.GiveDamage());
                    enemy.TakeDamage(player.GiveDamage());
                    System.Console.WriteLine($"{player.name} har {player.hp} hp | {enemy.name} har {enemy.hp} hp");

                    gameLoop = TestDead();
                    Console.ReadLine();
                    
                }
            }
            bool TestDead()
            {
                if(player.hp <= 0 && enemy.hp <= 0)
                {
                    Console.WriteLine($"Både du och {enemy.name} ramlade ihop och hämtadas av sjukvården");
                    return(false);

                }
                if(player.hp <= 0)
                {
                    Console.WriteLine($"Du blev nerslagen av {enemy.name}, skäms");
                    return(false);
                }
                if(enemy.hp <= 0)
                {
                    Console.WriteLine($"Du slog ner {enemy.name}, du är hjälte");
                    return(false);
                }
                return(true);
            }
            Fighter NewPlayer()
            {
                Fighter tempPlayer = new Fighter
                (
                    Names.playerNames[generator.Next(0, Names.playerNames.Length)],
                    standardPlayerLife
                );
                return(tempPlayer);
            }
            Fighter NewEnemy()
            {
                Fighter tempEnemy = new Fighter
                (
                    Names.enemyNames[generator.Next(0, Names.enemyNames.Length)],
                    standardEnemyLife
                );
                return(tempEnemy);
            }
        }
    }
}
