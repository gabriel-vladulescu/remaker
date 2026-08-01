namespace SSAR.BattleSystem.AI
{
	public class TurnAction : AbsAction
	{
		public bool turnRight;

		private TimerAction timerAction;

		public TurnAction(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
		}

		public override bool AwakeCondition()
		{
			return false;
		}

		protected override void OnChangeToAwake(bool cancelAnimation)
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
