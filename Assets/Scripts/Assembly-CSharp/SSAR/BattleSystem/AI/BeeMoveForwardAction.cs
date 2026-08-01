using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace SSAR.BattleSystem.AI
{
	public class BeeMoveForwardAction : AbsAction
	{
		public bool changeDirectionOneTime;

		public float[] rangeX;

		public float[] rangeY;

		public float amplitude;

		public float interval;

		public float verticalSpeed;

		public float[] offsetWithHead;

		private float frequency;

		private Vector3 direction;

		private float randomRange;

		private float m_offsetWithHead;

		private int verticalDirection;

		public float[] originalDuration;

		protected float randomDuration;

		protected float moveTime;

		private Direction dir;

		public BeeMoveForwardAction(NewMonsterAIComponent aiComponent, ActionConfig config)
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

		private bool IsEndDuration()
		{
			return false;
		}

		private Direction GetDir()
		{
			return default(Direction);
		}
	}
}
