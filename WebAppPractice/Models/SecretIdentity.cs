namespace WebAppPractice.Models
{
    public class SecretIdentity
    {
        public int Id { get; set; }
        public string? RealName { get; set; }
        public int HeroId { get; set; }
        public Hero? Hero { get; set; }
    }
}
