using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster75004
{
	public class Monster75004Skill2 : DefaultMeleeSkill
	{
		private class Info
		{
			public string dmgAnimName;

			public float dmgDuration;
		}

		private Info info;

		private bool hited;

		private EventFrame eventFrame;

		public Monster75004Skill2(Dependencies dependencies)
			: base(null)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		protected override bool ShouldPlayBeHitVfx(EventFrame eventFrame, Projectile projectile)
		{
			return false;
		}

		public override void OnProjectileHitTargets(Projectile projectile, List<Character> hitTargets)
		{
		}

		private void SkipToDamagePhase(Vector3 pos)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}
	}
}
