using Artemis;
using SSAR.BattleSystem.Movement;

namespace SSAR.BattleSystem.AI
{
	public class DashJumpEvadeSkillLogic : AbsEvadeSkillLogic
	{
		public float[] originalDuration;

		protected float randomDuration;

		private bool isExit;

		private float time;

		private Entity target;

		private int count;

		private bool isApproach;

		private TimerAction dash;

		private TimerAction jump;

		public DashJumpEvadeSkillLogic(Entity self, Entity target, float[] originalDuration, bool isApproach)
			: base(null)
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

		private Direction ApproachDirection()
		{
			return default(Direction);
		}

		private Direction GetMoveLeftDirection()
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
