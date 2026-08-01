using Assets.Scripts.Ssar.Combat.Skills;
using SSAR.BattleSystem.Damage;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.EventTriggers
{
	public class HpDropUsePotionEventTrigger : EventTrigger
	{
		private Skill s;

		private Dependencies dependencies;

		private Character caster;

		private HealthComponent healthComponent;

		private HpDropUsePotionConfig buff;

		private GameObject vfx;

		private bool justDropBelowLevel;

		private float elapsed;

		private float interval;

		public HpDropUsePotionEventTrigger(Skill s, Dependencies dependencies)
		{
		}

		public void OnCreated(Skill s)
		{
		}

		public void OnUpdate(float dt)
		{
		}

		private void UseHpPotion()
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
