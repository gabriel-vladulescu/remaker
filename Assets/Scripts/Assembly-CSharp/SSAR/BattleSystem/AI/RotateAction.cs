namespace SSAR.BattleSystem.AI
{
	public class RotateAction : AbsAction
	{
		private TimerAction timerAction;

		public bool turnBack;

		public RotateAction(NewMonsterAIComponent aiComponent, ActionConfig config)
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
