using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Damage;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster4200
{
	public class Monster4200PassiveSkill : DefaultPassiveSkill
	{
		public class SkillInfo
		{
			public int stack;

			public float duration;

			public float cooldown;

			public float stackCooldown;
		}

		private enum State
		{
			BuildUp = 0,
			Rage = 1,
			Recovery = 2
		}

		private SkillInfo info;

		private EventFrame damageFrame;

		private List<EventFrame> stackVfxFrames;

		private EventFrame fullStackVfxFrame;

		private List<GameObject> vfxFollowBones;

		private State state;

		private int currentStack;

		private float duration;

		public Monster4200PassiveSkill(Dependencies dependencies)
			: base(null)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		protected override void OnHitTargetEvent(Character target, DamageSource damageSource)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		protected override bool ShouldPlayBeHitVfx(EventFrame eventFrame, Projectile projectile)
		{
			return false;
		}

		protected override void OnVfxFollowBonePlayed(EventFrame ef, List<GameObject> vfxs)
		{
		}

		private void BuildStack()
		{
		}

		private void SetToBuildUp()
		{
		}

		private void SetToRage()
		{
		}

		private void SetToRecovery()
		{
		}

		private int GetMaxStack()
		{
			return 0;
		}

		private float GetRageDuration()
		{
			return 0f;
		}

		private float GetRecoveryDuration()
		{
			return 0f;
		}

		private float GetStackCooldown()
		{
			return 0f;
		}

		private void ApplyModifier(Character target)
		{
		}

		private EventFrame GetEventFrame()
		{
			return null;
		}

		private Projectile GetProjectile()
		{
			return null;
		}

		private void UpdateStackVfx()
		{
		}

		private void CleanVfxFollowBones()
		{
		}
	}
}
