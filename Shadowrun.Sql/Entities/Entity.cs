using System.ComponentModel.DataAnnotations;

namespace Shadowrun.Sql.Models
{
    public class Entity
    {
        [Key]
        public string name { get; set; }
        public int physicalMonitor { get; set; }
        public int stunMonitor { get; set; }
        public int painThreshold { get; set; }
        public int initDice { get; set; }
        public int initPlus { get; set; }
        public bool playerAsset { get; set; }
        public int physicalDamage { get; set; }
        public int stunDamage { get; set; }
        public int accruedRecoil { get; set; }
    }
}
