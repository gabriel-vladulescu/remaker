using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace SSAR.BattleSystem.AI
{
	public class BeeMoveBackwardAction : AbsAction
	{
		public float[] rangeY;

		public float[] backwardY;

		public float[] originalDuration;

		public float amplitude;

		public float interval;

		public float verticalSpeed;

		public bool reverse;

		private float frequency;

		private Vector3 direction;

		private float time;

		private float maxY;

		protected float randomDuration;

		private int verticalDirection;

		private Direction dir;

		public BeeMoveBackwardAction(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
		}

		protected override void MapValue(ActionConfig config)
		{
		}

		protected override void OnChangeToAwake(bool cancelAnimation)
		{
		}

		protected override bool IsExit()
		{
			return false;
		}

		protected override void OnExcute()
		{
		}

		protected override void OnExcute(float deltaTime)
		{
		}

		protected override void OnExit()
		{
		}

		private void InitMaxBackwardMaxY()
		{
		}
	}
}
