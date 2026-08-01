using SSAR.BattleSystem.AI;
using UnityEngine;

namespace Ssar.BattleSystem.AISystem.Condition
{
	public class TargetNotInRangeCondition : AbsCondition
	{
		public bool checkTargetInFrontOf;

		public Vector2 posOffset;

		public Vector2 hitBoxSizeMin;

		public Vector2 hitBoxSizeMax;

		private Vector2 boxSize;

		public TargetNotInRangeCondition(AbsAction absAction, NewMonsterAIComponent newMonsterAiComponent, ConditionConfig conditionConfig)
			: base(null, null, null)
		{
		}

		public override void OnChangeToAwake()
		{
		}

		public override void OnExcute()
		{
		}

		private void RandomSize()
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
