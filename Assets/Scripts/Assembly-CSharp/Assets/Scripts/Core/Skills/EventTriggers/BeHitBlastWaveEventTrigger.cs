using Assets.Scripts.Ssar.Combat.Skills;
using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Core.Skills.EventTriggers
{
	public class BeHitBlastWaveEventTrigger : EventTrigger
	{
		private Skill s;

		private Dependencies dependencies;

		private Character caster;

		private BeHitBlastWaveConfig config;

		private float lastTimeCast;

		public BeHitBlastWaveEventTrigger(Skill s, Dependencies dependencies)
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

		private bool IsCharacterCcImmune(Character character)
		{
			return false;
		}

		protected bool IsCharacterDamageImmune(Character character)
		{
			return false;
		}
	}
}
