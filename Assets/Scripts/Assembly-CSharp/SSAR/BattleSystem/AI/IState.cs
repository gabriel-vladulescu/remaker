namespace SSAR.BattleSystem.AI
{
	public interface IState
	{
		void OnEnter();

		void OnExit(IState nextState);
	}
}
