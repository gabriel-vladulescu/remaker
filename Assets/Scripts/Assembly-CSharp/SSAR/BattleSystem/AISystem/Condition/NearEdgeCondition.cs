using SSAR.BattleSystem.AI;

namespace Ssar.BattleSystem.AISystem.Condition
{
	public class NearEdgeCondition : AbsCondition
	{
		public float threshold;

		public bool reverse;

		public bool checkLeftRight;

		public bool isRightEdge;

		public NearEdgeCondition(AbsAction absAction, NewMonsterAIComponent newMonsterAiComponent, ConditionConfig conditionConfig)
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

		private bool IsNearEdge()
		{
			return false;
		}
	}
}
