using Assets.Scripts.Core.Skills.Modifiers;
using Assets.Scripts.Ssar.Combat.Skills;
using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Core.Skills.EventTriggers
{
	public class HpDropImmuneBuffEventTrigger : EventTrigger
	{
		private Skill skill;

		private Dependencies dependencies;

		private Character caster;

		private HealthComponent healthComponent;

		private WeaponPassiveSkillConfig config;

		private EventFrame buffEventFrame;

		private bool isTriggered;

		private float duration;

		private ModifierVfxManager vfxManager;

		public HpDropImmuneBuffEventTrigger(Skill skill, Dependencies dependencies)
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
	}
}
