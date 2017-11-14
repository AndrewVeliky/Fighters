using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FighterLogic
{

    public class Fighter
    {
        public event Action<int> HealthChanging;
        public event Action<string> StateChanging;
        protected static Random rand = new Random();
        private int health;
        private string state;

        public Fighter(string name, int health, int damage, byte[] photo)
        {
            Name = name;
            Health = health;
            Damage = damage;
            Photo = photo;
            HitPosibility = rand.Next(0, 100);
            BlockPosibility = rand.Next(0, 100);
            state = "0";
        }

        /*public Fighter(string name)
        {
            Name = name;
            Health = 100;
            Damage = rand.Next(10, 30);
            HitPosibility = rand.Next(0, 100);
            BlockPosibility = rand.Next(0, 100);
            state = "0";
        }
        */

        public string Name { get; set; }
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
                HealthChanging?.Invoke(Health);

            }
        }
        public int Damage { get; set; }
        public byte[] Photo { get; set; }
        private int HitPosibility { get; set; }
        private int BlockPosibility { get; set; }
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                StateChanging?.Invoke(State);
            }
        }



        public async Task<int> FightAsync(Fighter enemy)
        {
            while (true)
            {
                var hit = rand.Next(0, 100);
                var block = rand.Next(0, 100);
                var enemyHit = rand.Next(0, 100);
                var enemyBlock = rand.Next(0, 100);              

                if (hit <= HitPosibility && enemyBlock <= enemy.BlockPosibility)
                {
                    enemy.Health -= Damage;
                    State = "Hit " + Damage.ToString();
                }
                else if(hit > HitPosibility)
                {
                    State = "Missed";
                }
                else if (block > BlockPosibility)
                {
                    State = "Blocked";
                }

                if (enemyHit <= enemy.HitPosibility && block <= BlockPosibility)
                {
                    Health -= enemy.Damage;
                    enemy.State = "Hit " + enemy.Damage.ToString();
                }
                else if (enemyHit > enemy.HitPosibility)
                {
                    enemy.State = "Missed";
                }
                else if (enemyBlock > enemy.BlockPosibility)
                {
                    enemy.State = "Blocked";
                }

                if (Health <= 0 && enemy.Health <= 0)
                {
                    return 0;
                }
                if (Health <= 0)
                {
                    return -1;
                }

                if (enemy.Health <= 0)
                {
                    return 1;
                }
                await Task.Delay(1000);
            }
        }


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name.ToString());

            if (Health < 0)
            {
                sb.AppendLine("Health: 0");
            }
            else
            {
                sb.AppendLine(string.Format("Health: {0}", Health));
            }
            sb.AppendLine(string.Format("Damage: {0}", Damage));
            sb.AppendLine(new string('_', 10));

            return sb.ToString();
        }
    }
}
