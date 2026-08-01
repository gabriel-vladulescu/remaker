using SSAR.BattleSystem.AI;
using UnityEngine;

namespace Ssar.BattleSystem.AISystem.Condition
{
	public class ReactTimeCondition : AbsCondition
	{
		public Vector2 reactTime;

		private float time;

		private bool set;

		public ReactTimeCondition(AbsAction absAction, NewMonsterAIComponent newMonsterAiComponent, ConditionConfig conditionConfig)
			: base(null, null, null)
		{
		}

		protected override void MapValue(ConditionConfig config)
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
