using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster4100
{
	public class Monster4100Skill3 : DefaultMeleeSkill
	{
		public class SkillInfo
		{
			public float minRange;

			public float maxRange;

			public float jumpTime;

			public float jumpDistanceOffset;

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

		private EventFrame jumpFrame;

		private float interval;

		private State adjustAnimSpdState;

		private float originalAnimSpeed;

		public Monster4100Skill3(Dependencies dependencies)
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

		public override void Interrupt()
		{
		}

		public override void OnProjectileHitTargetsForFirstTime(Projectile projectile, List<Character> hitTargets)
		{
		}

		private void Activate()
		{
		}

		private float GetDistance()
		{
			return 0f;
		}
	}
}
