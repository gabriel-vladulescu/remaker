using System.Collections.Generic;
using Assets.Scripts.Ssar.Combat.Skills;
using SSAR.BattleSystem.Damage;
using SSAR.Dungeon.Caching;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.EventTriggers
{
	public class HpDropAttackBuffEventTrigger : EventTrigger
	{
		private Skill s;

		private Dependencies dependencies;

		private Character caster;

		private AttackComponent attackComponent;

		private HealthComponent healthComponent;

		private CachingComponent cachingComponent;

		private HpDropAttackBuffConfig buff;

		private List<GameObject> vfxs;

		private List<GameObject> bones;

		private bool justDropBelowLevel;

		private float attackBonus;

		public HpDropAttackBuffEventTrigger(Skill s, Dependencies dependencies)
		{
		}

		public void OnCreated(Skill s)
		{
		}

		public void OnUpdate(float dt)
		{
		}

		private void PlaySfx(string path)
		{
		}

		private Vector3 VfxPos(GameObject bone)
		{
			return default(Vector3);
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
