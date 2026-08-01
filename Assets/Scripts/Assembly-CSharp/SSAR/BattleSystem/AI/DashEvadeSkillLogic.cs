using Artemis;
using SSAR.BattleSystem.Movement;

namespace SSAR.BattleSystem.AI
{
	public class DashEvadeSkillLogic : AbsEvadeSkillLogic
	{
		public float[] originalDuration;

		protected float randomDuration;

		private bool isExit;

		private float time;

		private int count;

		private bool _isApproach;

		private Entity target;

		private Direction direction;

		private TimerAction timerAction;

		private float distanceToEdgeChangeDirection;

		private Direction overrideDirection;

		private bool fixDirection;

		public DashEvadeSkillLogic(Entity self, Entity target, float[] originalDuration, bool isApproach, float distanceToEdgeChangeDirection)
			: base(null)
		{
		}

		public void SetDirection(Direction direction)
		{
		}

		public override bool IsExit()
		{
			return false;
		}

		public override void OnExit()
		{
		}

		public override void OnExcute()
		{
		}

		private Direction GetMoveLeftDirection()
		{
			return default(Direction);
		}

		private Direction ApproachDirection()
		{
			return default(Direction);
		}

		public override void OnExcute(float deltaTime)
		{
		}

		public override void OnAwake()
		{
		}
	}
}
