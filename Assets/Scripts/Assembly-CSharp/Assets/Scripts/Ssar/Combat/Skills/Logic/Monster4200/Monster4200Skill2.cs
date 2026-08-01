using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster4200
{
	public class Monster4200Skill2 : DefaultMeleeSkill
	{
		public class SkillInfo
		{
			public class AttackData
			{
				public float activationTime;

				public float delayOut;

				public float delayIn;

				public float delayDamage;

				public float delayFx;

				public float delayAnim;

				public float delayTrackTarget;
			}

			public string atkAnim;

			public string recoveryAnim;

			public float recoveryTime;

			public string triggerSubSkill;

			public List<AttackData> attackDatas;
		}

		private SkillInfo info;

		private EventFrame damageFrame;

		private EventFrame vfxFrame;

		private EventFrame teleportOutFrame;

		private EventFrame teleportInFrame;

		private HealthComponent healthComponent;

		private int activationIndex;

		public Monster4200Skill2(Dependencies dependencies)
			: base(null)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		public override void OnCast(Character character)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		protected override void OnProjectileCreated(Projectile projectile)
		{
		}

		public override void OnFinish(Character character)
		{
		}

		public override void Interrupt()
		{
		}

		private void ActivateTeleportOut(float activationTime, float delayTime)
		{
		}

		private void ActivateTeleportIn(float activationTime, float delayTime, float delayTrack)
		{
		}

		private void ActivateDamage(float activationTime, float delayTime)
		{
		}

		private void ActivateFX(float activationTime, float delayTime)
		{
		}

		private void SetBeatable(bool value)
		{
		}
	}
}
