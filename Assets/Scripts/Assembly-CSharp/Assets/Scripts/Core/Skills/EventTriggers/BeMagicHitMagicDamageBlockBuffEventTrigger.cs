using Assets.Scripts.Core.Skills.Modifiers;
using Assets.Scripts.Ssar.Combat.Skills;
using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Core.Skills.EventTriggers
{
	public class BeMagicHitMagicDamageBlockBuffEventTrigger : EventTrigger
	{
		private Skill skill;

		private Dependencies dependencies;

		private Character caster;

		private WeaponPassiveSkillConfig config;

		private EventFrame buffEventFrame;

		private float lastTimeCast;

		private ModifierVfxManager vfxManager;

		public BeMagicHitMagicDamageBlockBuffEventTrigger(Skill skill, Dependencies dependencies)
		{
		}

		public void OnCreated(Skill s)
		{
		}

		public void OnUpdate(float dt)
		{
		}

		public void OnBeHit(Character byCaster)
		{
		}

		public void OnHitTarget(Character target, DamageSource source)
		{
		}

		public void OnProjectileLaunch(Skill bySkill)
		{
		}

		public void OnEventFrameAdd(EventFrame ef)
		{
		}

		public void OnSkillCasted(Skill skill)
		{
		}

		public void OnInterrupt()
		{
		}

		private void OnEntityTakeHpChange(DamageInfo damageInfo)
		{
		}
	}
}
