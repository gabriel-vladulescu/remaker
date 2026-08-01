using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster75003
{
	public class Monster75003Skill2 : DefaultMeleeSkill
	{
		private class Info
		{
			public string recoveryAnimationName;

			public float playRecoveryAnimationAt;

			public float whenDashHitFastforwardTo;
		}

		private Info info;

		private bool hited;

		private EventFrame eventFrame;

		private string animationName;

		private float animationElapsed;

		private float animationDuration;

		private bool isRecoveryAnimationPlayed;

		private Transform eyesTrail;

		public Monster75003Skill2(Dependencies dependencies)
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

		private void SkipToDamagePhase()
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		public override void OnFinish(Character character)
		{
		}
	}
}
