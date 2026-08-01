namespace SSAR.BattleSystem.Movement
{
	public class JumpRequest : AbsRequest
	{
		private int count;

		public JumpData jumpData;

		private bool jumpFromDash;

		private readonly float floatingDuration;

		private readonly bool jumpBackward;

		public bool JumpFromDash => false;

		public JumpRequest(AccessLevel accessLevel, JumpData jumpData, bool jumpFromDash = false, float floatingDuration = 0f, bool jumpBackward = false)
			: base(default(AccessLevel))
		{
		}

		public override void OnAttach()
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

		public override int Priority()
		{
			return 0;
		}
	}
}
