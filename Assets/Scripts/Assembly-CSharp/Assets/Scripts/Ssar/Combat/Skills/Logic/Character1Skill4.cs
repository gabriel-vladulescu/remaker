using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class Character1Skill4 : DefaultMeleeSkill
	{
		private List<EventFrame> processedEventFrames;

		public Character1Skill4(Dependencies dependencies)
			: base(null)
		{
		}

		protected override List<Projectile> OnLaunchProjectiles(EventFrame ef)
		{
			return null;
		}

		protected override void PostModifierInfoAddition(EventFrame ef, DamageInfo damageInfo)
		{
		}
	}
}
