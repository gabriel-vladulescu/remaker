using Assets.Scripts.Ssar.Combat.Skills;
using SSAR.BattleSystem.Damage;
using Scripts.Config;

namespace Assets.Scripts.Core.Skills.EventTriggers
{
	public class ShockwaveEventTrigger : EventTrigger
	{
		private Skill s;

		private Dependencies d;

		private EventFrame eventFrame;

		private Character character;

		private HeroConfig hc;

		private ComboDamageFrameShockwaveConfig config;

		public ShockwaveEventTrigger(Skill s, Dependencies d)
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
