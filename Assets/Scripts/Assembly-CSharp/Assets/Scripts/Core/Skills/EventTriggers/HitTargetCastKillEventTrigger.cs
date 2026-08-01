using System.Collections.Generic;
using Assets.Scripts.Ssar.Combat.Skills;
using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Core.Skills.EventTriggers
{
	public class HitTargetCastKillEventTrigger : EventTrigger
	{
		private Skill skill;

		private Dependencies dependencies;

		private ModifierConfig mc;

		private Character caster;

		private HitTargetCastSkillConfig config;

		private List<int> triggeredId;

		public HitTargetCastKillEventTrigger(Skill skill, Dependencies dependencies, ModifierConfig mc)
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
