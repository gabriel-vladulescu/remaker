using SSAR.BattleSystem.AI;

namespace Ssar.BattleSystem.AISystem.Condition
{
	public class TargetRunningCondition : AbsCondition
	{
		public bool reverse;

		public TargetRunningCondition(AbsAction absAction, NewMonsterAIComponent newMonsterAiComponent, ConditionConfig conditionConfig)
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

		private bool IsTargetRunning()
		{
			return false;
		}
	}
}
