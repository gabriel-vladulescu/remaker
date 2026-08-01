namespace SSAR.BattleSystem.CharacterStatus
{
	public class DeathStatus : ICharacterStatus
	{
		private DeathReason reason;

		private readonly float duration;

		private float time;

		public DeathReason Reason
		{
			get
			{
				return default(DeathReason);
			}
			set
			{
			}
		}

		public DeathStatus(DeathReason reason)
		{
		}

		public DeathStatus(DeathReason reason, float duration)
		{
		}

		public void Enter()
		{
		}

		public void Update(float deltaTime)
		{
		}

		public void Exit()
		{
		}

		public bool IsExit()
		{
			return false;
		}

		public Status CharacterStatus()
		{
			return default(Status);
		}
	}
}
