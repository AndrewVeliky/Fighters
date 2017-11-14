using FighterLogic;
using System;
using System.Collections.Generic;




namespace Fighters
{
    class Program 
    {
        static void Main(string[] args)
        {
            /*do
            {
                var Heroes = new List<Fighter>();
                var rnd = new Random();    
                
                Heroes.Add(new Fighter(FightersName.Captain_America));

                Heroes.Add(new Fighter(FightersName.Iron_Man));

                foreach (var fighter in Heroes)
                {
                    Console.WriteLine(fighter.ToString());
                }

                Console.WriteLine("Make your bet:\n");
                var bet = (FightersName)Int32.Parse(Console.ReadLine());

                if (bet == FightersName.Captain_America || bet == FightersName.Iron_Man)
                {
                    Console.WriteLine("You choose: {0}\n\n", bet);
                    Result(Heroes[0], Heroes[1], bet);
                    
                }
                else
                {
                    Console.WriteLine("Choose 1 or 2");
                }


                Console.ReadLine();
                Console.Clear();
            }
            while (true);

        }

       

        public static void Result(Fighter fighter1, Fighter fighter2, FightersName bet)
        {
            var winner = FightersName.Undefined;
    
            switch (fighter1.FightAsync(fighter2))
            {
                case -1:
                    winner = fighter2.Name;
                    Console.WriteLine("{0} wins!\n", fighter2.Name);
                    break;
                case 1:
                    winner = fighter1.Name;
                    Console.WriteLine("{0} wins!\n", fighter1.Name);
                    break;
                case 0:
                    Console.WriteLine("Draw\n");
                    break;
            }

            Console.WriteLine("Results:\n");
            Console.WriteLine(fighter1.ToString());
            Console.WriteLine(fighter2.ToString());

            if (bet == winner)
            {
                Console.WriteLine("You Win!");
            }
            else
            {
                Console.WriteLine("You Lose!");
            }
            
    */
        }


        
    }
}
