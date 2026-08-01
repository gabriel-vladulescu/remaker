namespace SSAR.BattleSystem.AI
{
	public class MoveBackwardAction : MoveForwardAction
	{
		public bool changeFaceDirection;

		public MoveBackwardAction(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
		}

		protected override void OnExcute(float deltaTime)
		{
		}

		protected override bool CheckMinRangeToEnable()
		{
			return false;
		}

		protected override void OnExit()
		{
		}

		protected override bool ExitCondition()
		{
			return false;
		}

		private bool IsInRange()
		{
			return false;
		}

		protected override bool EnableCondition()
		{
			return false;
		}
	}
}
