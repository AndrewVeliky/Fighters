namespace FightersForm
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FighterContext : DbContext
    {
        public FighterContext()
            : base("name=FighterContext")
        {
        }

        public virtual DbSet<Fighters> Fighters { get; set; }
        public virtual DbSet<FightHistories> FightHistories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
