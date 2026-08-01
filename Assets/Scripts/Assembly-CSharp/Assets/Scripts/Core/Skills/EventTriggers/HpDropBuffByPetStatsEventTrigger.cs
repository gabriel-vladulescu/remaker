using System.Collections.Generic;
using Assets.Scripts.Core.Skills.Modifiers;
using Assets.Scripts.Ssar.Combat.Skills;
using SSAR.BattleSystem.Damage;
using SSAR.Dungeon.Caching;
using SSAR.Dungeon.View;
using Scripts.Ssar.Pet;

namespace Assets.Scripts.Core.Skills.EventTriggers
{
	public class HpDropBuffByPetStatsEventTrigger : EventTrigger
	{
		private Skill skill;

		private Dependencies dependencies;

		private Character caster;

		private AttackComponent attackComponent;

		private HealthComponent healthComponent;

		private PetListComponent petListComponent;

		private WeaponPassiveSkillConfig config;

		private bool isTriggered;

		private float duration;

		private float deltaAttack;

		private float deltaDef;

		private ModifierVfxManager vfxManager;

		private SpecialModifierVisualInfo modifierVisualInfo;

		public HpDropBuffByPetStatsEventTrigger(Skill skill, Dependencies dependencies)
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

		private PetShareStat GetPetShareStat(List<PetShareStat> shareStats, ShareStatType statType)
		{
			return null;
		}
	}
}
