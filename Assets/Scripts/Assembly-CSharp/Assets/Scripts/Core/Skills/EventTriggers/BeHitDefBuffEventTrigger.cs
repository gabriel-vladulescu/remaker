using Assets.Scripts.Core.Skills.Modifiers;
using Assets.Scripts.Ssar.Combat.Skills;
using SSAR.BattleSystem.Damage;
using SSAR.Dungeon.View;

namespace Assets.Scripts.Core.Skills.EventTriggers
{
	public class BeHitDefBuffEventTrigger : EventTrigger
	{
		private Skill skill;

		private Dependencies dependencies;

		private Character caster;

		private HealthComponent healthComponent;

		private WeaponPassiveSkillConfig config;

		private float duration;

		private int stack;

		private float defBonus;

		private ModifierVfxManager vfxManager;

		private SpecialModifierVisualInfo modifierVisualInfo;

		public BeHitDefBuffEventTrigger(Skill skill, Dependencies dependencies)
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

		private void DeactivateBuff()
		{
		}
	}
}
