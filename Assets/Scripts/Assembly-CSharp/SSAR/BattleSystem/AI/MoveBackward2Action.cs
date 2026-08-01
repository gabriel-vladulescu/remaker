namespace SSAR.BattleSystem.AI
{
	public class MoveBackward2Action : MoveForward2Action
	{
		public bool changeFaceDirection;

		public MoveBackward2Action(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
		}

		protected override void OnExcute(float deltaTime)
		{
		}

		protected override void OnExit()
		{
		}
	}
}
