using Microsoft.EntityFrameworkCore;
using WebAppPractice.Models;

namespace WebAppPractice.Data
{
    public class HeroContext : DbContext 
    {
        public DbSet<Hero>? Heros { get; set; }
        public DbSet<Battle>? Battles { get; set; }
        public DbSet<Weapon>? Weapons { get; set; }
        public DbSet<HeroBattle>? HerosBattles { get; set; }
        public DbSet<SecretIdentity>? SecretsIdentities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Persist Security Info=True;Initial Catalog=HeroApp"); //Put your string connection here
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroBattle>(entity =>
            {
                entity.HasKey(e => new { e.BattleId, e.HeroId });
            });
        }
    }
}
