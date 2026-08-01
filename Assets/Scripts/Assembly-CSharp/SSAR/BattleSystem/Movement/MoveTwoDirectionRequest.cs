namespace SSAR.BattleSystem.Movement
{
	public class MoveTwoDirectionRequest : AbsRequest
	{
		private int count;

		public Direction dir;

		private MovementComponent movement;

		private bool changeFaceDirection;

		private float horizontalSpeed;

		private float verticalSpeed;

		private bool isMoveUp;

		public MoveTwoDirectionRequest(AccessLevel accessLevel, float horizontalSpeed, float verticalSpeed, Direction dir, bool isMoveUp, bool changeFaceDirection)
			: base(default(AccessLevel))
		{
		}

		public override void Update(float deltaTime)
		{
		}

		public override bool Expired()
		{
			return false;
		}

		public override void Exit()
		{
		}

		public override void OnAttach()
		{
		}

		public override int Priority()
		{
			return 0;
		}
	}
}
