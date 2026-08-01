using System.Collections.Generic;
using UnityEngine;

namespace SSAR.BattleSystem.AI
{
	public class FlierForwardAction : AbsAction
	{
		public List<MovementInfo> movement;

		private GameObject trans;

		private Vector3[] targetPos;

		private LTDescr control;

		private bool finish;

		private List<MovementInfo> movValidated;

		public FlierForwardAction(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
		}

		protected override void MapValue(ActionConfig config)
		{
		}

		public override bool AwakeCondition()
		{
			return false;
		}

		protected override void OnExcute()
		{
		}

		protected override void OnExit()
		{
		}

		protected override void OnExcute(float deltaTime)
		{
		}

		protected override bool IsExit()
		{
			return false;
		}
	}
}
