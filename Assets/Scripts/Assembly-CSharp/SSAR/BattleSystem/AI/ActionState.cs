namespace SSAR.BattleSystem.AI
{
	public abstract class ActionState : IState
	{
		public void OnEnter()
		{
		}

		public void Update(float deltaTime)
		{
		}

		public void OnExit(IState nextState)
		{
		}

		protected virtual void onEnter()
		{
		}

		protected virtual void onUpdate(float deltaTime)
		{
		}

		protected virtual void onExit(IState nextState)
		{
		}
	}
}
