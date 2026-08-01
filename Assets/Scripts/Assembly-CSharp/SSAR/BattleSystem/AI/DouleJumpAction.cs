namespace SSAR.BattleSystem.AI
{
	public class DouleJumpAction : AbsAction
	{
		private TimerAction exitJump1;

		private TimerAction jump2;

		private TimerAction exitJump2;

		public DouleJumpAction(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
		}

		protected override void OnExcute()
		{
		}

		protected override void OnExcute(float deltaTime)
		{
		}
	}
}
