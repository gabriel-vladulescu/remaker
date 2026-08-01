using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Core.Skills.EventTriggers
{
	public interface EventTrigger
	{
		void OnCreated(Skill s);

		void OnUpdate(float dt);

		void OnBeHit(Character byCaster);

		void OnHitTarget(Character target, DamageSource source);

		void OnProjectileLaunch(Skill bySkill);

		void OnEventFrameAdd(EventFrame ef);

		void OnSkillCasted(Skill skill);

		void OnInterrupt();
	}
}
