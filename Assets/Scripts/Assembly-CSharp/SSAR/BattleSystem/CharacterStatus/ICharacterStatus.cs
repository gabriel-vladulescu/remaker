namespace SSAR.BattleSystem.CharacterStatus
{
	public interface ICharacterStatus
	{
		void Enter();

		void Update(float deltaTime);

		void Exit();

		bool IsExit();

		Status CharacterStatus();
	}
}
