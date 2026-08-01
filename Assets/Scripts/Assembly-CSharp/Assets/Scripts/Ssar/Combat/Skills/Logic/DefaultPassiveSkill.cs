using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultPassiveSkill : DefaultMeleeSkill
	{
		private Environment environment;

		private GameObject damageVfxNotification;

		private float startTime;

		private bool turnOffVfx;

		private float turnOffDuration;

		private EventFrame ef;

		public DefaultPassiveSkill(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		protected override void PlayAnimation(Character character)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		public override void OnProjectileHitTargets(Projectile projectile, List<Character> hitTargets)
		{
		}

		protected override bool ShouldIgnoreThisHit(EventFrame ef, Projectile projectile, List<Character> hitCharacters)
		{
			return false;
		}

		public override void OnFinish(Character character)
		{
		}

		private void DestroyVfx()
		{
		}

		public override void Interrupt()
		{
		}

		private bool IsCastingIgnoreSkills()
		{
			return false;
		}

		private void EnableDamageVfxNotification()
		{
		}

		private void DisableDamageVfxNotification()
		{
		}
	}
}
