using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Damage;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Ancient
{
	public class Ancient7000Skill : DefaultRangerSkill
	{
		private class CustomMelee : DefaultMeleeSkill
		{
			private Ancient7000Skill mainSkill;

			public CustomMelee(Dependencies dependencies, Ancient7000Skill mainSkill)
				: base(null)
			{
			}

			protected override void PostModifierInfoAddition(EventFrame ef, DamageInfo damageInfo)
			{
			}
		}

		private EventFrame meleeEventFrame;

		private readonly CustomMelee meleeSkill;

		public Ancient7000Skill(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		protected override void OnProjectileFinishEvent(Projectile projectile)
		{
		}

		private void SpawnMelee(Vector2 pos)
		{
		}
	}
}
