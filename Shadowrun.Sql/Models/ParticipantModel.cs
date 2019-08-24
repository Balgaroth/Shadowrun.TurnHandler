namespace Shadowrun.Sql.Models
{
    public class ParticipantModel : Entity
    {
        public int initiative { get; set; }
        public bool actionPass { get; set; }
        public int physicalDamage { get; set; }
        public int stunDamage { get; set; }
        public int actionModifier { get; set; }
        public int defensiveActions { get; set; }
        public int accruedRecoil { get; set; }
    }
}
