namespace WebAppPractice.Models
{
    public class HeroBattle
    {
        public int HeroId { get; set; }
        public Hero? Hero { get; set; }
        public int BattleId { get; set; }
        public Battle? Battle { get; set; }
    }
}
