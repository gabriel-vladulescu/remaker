using SSAR.BattleSystem.AI;

namespace Ssar.BattleSystem.AISystem.Condition
{
	public class InDangerousAreaCondition : AbsCondition
	{
		public bool reverse;

		private DangerousArea dangerousArea;

		public InDangerousAreaCondition(AbsAction absAction, NewMonsterAIComponent newMonsterAiComponent, ConditionConfig conditionConfig)
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
	}
}
