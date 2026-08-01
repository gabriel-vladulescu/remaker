using Artemis;
using SSAR.BattleSystem.AI;

namespace Ssar.BattleSystem.AISystem.Condition
{
	public class TargetCanCastSkillCondition : AbsCondition
	{
		public bool reverse;

		public string skillId;

		public TargetCanCastSkillCondition(AbsAction absAction, NewMonsterAIComponent newMonsterAiComponent, ConditionConfig conditionConfig)
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

		private bool CanCastSkill()
		{
			return false;
		}

		public bool IsFinishCooldown(Entity target, string skillId)
		{
			return false;
		}
	}
}
