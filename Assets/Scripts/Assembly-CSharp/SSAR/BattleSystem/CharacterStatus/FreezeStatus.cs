namespace SSAR.BattleSystem.CharacterStatus
{
	public class FreezeStatus : ICharacterStatus
	{
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
