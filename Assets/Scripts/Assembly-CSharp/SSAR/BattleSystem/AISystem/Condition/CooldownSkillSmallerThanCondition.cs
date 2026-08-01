using Artemis;
using Assets.Scripts.Core.Skills.Cooldowns;
using SSAR.BattleSystem.AI;

namespace Ssar.BattleSystem.AISystem.Condition
{
	public class CooldownSkillSmallerThanCondition : AbsCondition
	{
		public string skillId;

		public string selfSkillId;

		public CooldownSkillSmallerThanCondition(AbsAction absAction, NewMonsterAIComponent newMonsterAiComponent, ConditionConfig conditionConfig)
			: base(null, null, null)
		{
		}

		public override void OnChangeToAwake()
		{
		}

		public override void OnExcute()
		{
		}

		public override void OnExcuteAction(float deltaTime)
		{
		}

		public override void OnExcuteOutOfAction(float deltaTime)
		{
		}

		public override void OnExitAction()
		{
		}

		public override bool IsMeetCondition()
		{
			return false;
		}

		public Cooldown GetCooldown(Entity target, string skillId)
		{
			return null;
		}
	}
}
