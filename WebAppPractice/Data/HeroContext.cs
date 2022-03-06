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
            optionsBuilder.UseSqlServer("Password=ksv123456;Persist Security Info=True;User ID=ksv;Initial Catalog=HeroApp;Data Source=DESKTOP-6FU40B9");
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
