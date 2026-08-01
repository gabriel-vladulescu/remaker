using SSAR.BattleSystem.AI;
using UnityEngine;

namespace Ssar.BattleSystem.AISystem.Condition
{
	public class TargetInRangeCondition : AbsCondition
	{
		public bool drawGizmo;

		public bool checkTargetInFrontOf;

		public float percent;

		public Vector2 posOffset;

		public Vector2 hitBoxSizeMin;

		public Vector2 hitBoxSizeMax;

		private Vector2 boxSize;

		public TargetInRangeCondition(AbsAction absAction, NewMonsterAIComponent newMonsterAiComponent, ConditionConfig conditionConfig)
			: base(null, null, null)
		{
		}

		public override void OnChangeToAwake()
		{
		}

		private void RandomSize()
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
