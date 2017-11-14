using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageFighters
{
    class ManageFightersContext : DbContext
    {
        public ManageFightersContext() 
        :base("DefaultConnection")
    { }

        public DbSet<Fighters> Fighters { get; set; }
        public DbSet<FightHistory> FightHistory { get; set; }
    }
}
