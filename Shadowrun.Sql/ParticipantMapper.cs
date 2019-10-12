using Shadowrun.Sql.Models;

namespace Shadowrun.Sql
{
    public static class ParticipantMapper
    {
        public static Entity ParticipantToEntity(ParticipantModel participant)
        {
            return new Entity
            {
                name = participant.name,
                physicalMonitor = participant.physicalMonitor,
                stunMonitor = participant.stunMonitor,
                painThreshold = participant.painThreshold,
                initDice = participant.initDice,
                initPlus = participant.initPlus,
                playerAsset = participant.playerAsset,
                accruedRecoil = participant.accruedRecoil,
                physicalDamage = participant.physicalDamage,
                stunDamage = participant.stunDamage
            };
        }

        public static ParticipantModel EntityToParticipantModel(Entity entity)
        {
            return new ParticipantModel
            {
                name = entity.name,
                physicalMonitor = entity.physicalMonitor,
                stunMonitor = entity.stunMonitor,
                painThreshold = entity.painThreshold,
                initDice = entity.initDice,
                initPlus = entity.initPlus,
                playerAsset = entity.playerAsset,
                accruedRecoil = entity.accruedRecoil,
                physicalDamage = entity.physicalDamage,
                stunDamage = entity.stunDamage
            };
        }
    }
}
