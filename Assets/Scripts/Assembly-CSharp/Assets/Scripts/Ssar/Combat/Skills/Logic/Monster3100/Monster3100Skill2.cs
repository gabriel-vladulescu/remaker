using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Modifiers;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster3100
{
	public class Monster3100Skill2 : DefaultRangerSkill
	{
		public class SkillInfo
		{
			public float destructibleTime;
		}

		private SkillInfo skillInfo;

		private List<EventFrame> processedEventFrames;

		private bool isDestructible;

		private readonly Assets.Scripts.Core.Skills.Modifiers.ModifierType[] cancelableModifierTypes;

		public Monster3100Skill2(Dependencies dependencies)
			: base(null)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		protected override bool ShouldDestroyProjectileOnTargetHit()
		{
			return false;
		}

		protected override List<Projectile> OnLaunchProjectiles(EventFrame ef)
		{
			return null;
		}

		public override void OnProjectileHitTargetsForFirstTime(Projectile projectile, List<Character> hitTargets)
		{
		}

		protected override void PostModifierInfoAddition(EventFrame ef, DamageInfo damageInfo)
		{
		}
	}
}
