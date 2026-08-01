namespace SSAR.BattleSystem.Movement
{
	public class RunRequest : AbsRequest
	{
		private int count;

		public Direction dir;

		private RunData runData;

		private MovementComponent movement;

		private bool changeFaceDirection;

		private bool influenceByEnvironment;

		public RunRequest(AccessLevel accessLevel, RunData runData, Direction dir, bool changeFaceDirection, bool influenceByEnvironment = false)
			: base(accessLevel)
		{
			this.runData = runData;
			this.dir = dir;
			this.changeFaceDirection = changeFaceDirection;
			this.influenceByEnvironment = influenceByEnvironment;
		}

		public override void Update(float deltaTime)
		{
			if (movement == null)
			{
				return;
			}

			if (changeFaceDirection)
			{
				movement.UpdateDirection(dir);
			}

			float speed = movement.RunSpeed();
			movement.velocity.x = (float)dir * speed;
		}

		public override bool Expired()
		{
			return false;
		}

		public override void Exit()
		{
			if (movement != null)
			{
				movement.velocity.x = 0f;
			}
		}

		public override void OnAttach()
		{
			movement = self != null ? self.GetComponent<MovementComponent>() : null;
		}

		public override int Priority()
		{
			return 1;
		}

		public override bool InfluenceByEnvironment()
		{
			return influenceByEnvironment;
		}
	}
}
