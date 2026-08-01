using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster4005
{
	public class Monster4005Skill1 : DefaultMeleeSkill
	{
		public class SkillInfo
		{
			public float adjustAnimSpdFrom;

			public float adjustAnimSpdTo;

			public float animSpeed;
		}

		private enum State
		{
			Ready = 0,
			Processing = 1,
			Recovery = 2
		}

		private SkillInfo info;

		private EventFrame hitFrame;

		private bool hited;

		private float checkHitDuration;

		private State adjustAnimSpdState;

		private float originalAnimSpeed;

		public Monster4005Skill1(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		public override void OnProjectileHitTargetsForFirstTime(Projectile projectile, List<Character> hitTargets)
		{
		}

		public override void OnProjectileHitTargets(Projectile projectile, List<Character> hitTargets)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		public override void Interrupt()
		{
		}
	}
}
