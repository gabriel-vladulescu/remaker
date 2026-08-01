using Assets.Scripts.Core.Skills.Modifiers;
using Assets.Scripts.Ssar.Combat.Skills;
using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Core.Skills.EventTriggers
{
	public class HpDropAllInEventTrigger : EventTrigger
	{
		private enum Phase
		{
			Default = 0,
			Buff = 1,
			Debuff = 2
		}

		private Skill skill;

		private Dependencies dependencies;

		private Character caster;

		private AttackComponent attackComponent;

		private HealthComponent healthComponent;

		private WeaponPassiveSkillConfig config;

		private Phase phase;

		private float duration;

		private float attackBonus;

		private float defBonus;

		private ModifierVfxManager vfxManager;

		public HpDropAllInEventTrigger(Skill skill, Dependencies dependencies)
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

		private void ActivateBuff()
		{
		}

		private void ActivateDebuff()
		{
		}

		private void Deactivate()
		{
		}
	}
}
