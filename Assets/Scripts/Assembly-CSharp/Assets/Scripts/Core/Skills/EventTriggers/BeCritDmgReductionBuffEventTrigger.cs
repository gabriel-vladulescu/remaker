using Assets.Scripts.Core.Skills.Modifiers;
using Assets.Scripts.Ssar.Combat.Skills;
using SSAR.BattleSystem.Damage;
using SSAR.Dungeon.View;

namespace Assets.Scripts.Core.Skills.EventTriggers
{
	public class BeCritDmgReductionBuffEventTrigger : EventTrigger
	{
		private Skill skill;

		private Dependencies dependencies;

		private Character caster;

		private HealthComponent healthComponent;

		private WeaponPassiveSkillConfig config;

		private float lastTimeCast;

		private float duration;

		private float dmgReductionBonus;

		private ModifierVfxManager vfxManager;

		private SpecialModifierVisualInfo modifierVisualInfo;

		public BeCritDmgReductionBuffEventTrigger(Skill skill, Dependencies dependencies)
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

		private void ActivateBuff()
		{
		}

		private void DeactivateBuff()
		{
		}
	}
}
