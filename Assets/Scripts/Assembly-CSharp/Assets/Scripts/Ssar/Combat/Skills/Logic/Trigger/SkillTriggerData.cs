using Assets.Scripts.Core.Skills.Projectiles;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Trigger
{
	public class SkillTriggerData
	{
		private TriggerType triggerType;

		private ModifierConfig modifierConfig;

		private Projectile sourceProjectile;

		public TriggerType TriggerType => default(TriggerType);

		public ModifierConfig ModifierConfig => null;

		public Projectile SourceProjectile => null;

		public ModifierType ModifierType => default(ModifierType);

		public SkillTriggerData(TriggerType triggerType, ModifierConfig modifierConfig, Projectile sourceProjectile)
		{
		}
	}
}
