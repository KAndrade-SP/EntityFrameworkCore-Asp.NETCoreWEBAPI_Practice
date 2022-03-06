namespace WebAppPractice.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public SecretIdentity? SecretIdentity { get; set; }
        public List<Weapon>? Weapons { get; set; }
        public List<HeroBattle>? HerosBattles { get; set; }
    }
}
