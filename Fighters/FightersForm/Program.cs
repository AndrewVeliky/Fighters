using System;
using System.Windows.Forms;


namespace FightersForm
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FightersForms());
            
            
        }



        /*public static void Result(Fighter fighter1, Fighter fighter2, FightersNames bet)
        {
            var winner = FightersNames.Undefined;

            switch (fighter1.CompareTo(fighter2))
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


        }*/
    }
}
