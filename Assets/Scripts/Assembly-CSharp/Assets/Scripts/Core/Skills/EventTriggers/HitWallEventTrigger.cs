using Assets.Scripts.Ssar.Combat.Skills;
using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Core.Skills.EventTriggers
{
	public class HitWallEventTrigger : EventTrigger
	{
		private Skill skill;

		private Dependencies dependencies;

		private EventFrame eventFrame;

		private ActionFrameConfig actionFrameConfig;

		private Character caster;

		private WeaponPassiveSkillConfig config;

		private float projectileRadius;

		private float mostLeft;

		private float mostRight;

		private bool isFinish;

		public HitWallEventTrigger(Skill skill, Dependencies dependencies, ActionFrameConfig actionFrameConfig, EventFrame eventFrame)
		{
		}

		public void OnUpdate(float dt)
		{
		}

		private void HitWall()
		{
		}

		public void OnSkillCasted(Skill skill)
		{
		}

		public void OnCreated(Skill s)
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

		public void OnInterrupt()
		{
		}
	}
}
