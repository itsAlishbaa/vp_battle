namespace vp_battle.Components.Models
{
    public class BattleRecord
    {
        public int Id { get; set; }

        public string Winner { get; set; }
        public string Loser { get; set; }

        public int KnightHealth { get; set; }
        public int SkeletonHealth { get; set; }

        public DateTime BattleTime { get; set; } = DateTime.Now;
    }
}
