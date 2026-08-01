namespace SSAR.BattleSystem.AI
{
	public class MoveAction : AbsAction
	{
		public bool moveRight;

		public MoveAction(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
		}

		protected override void OnExcute()
		{
		}

		protected override void OnExcute(float deltaTime)
		{
		}

		private bool IsInSkillState()
		{
			return false;
		}

		public override bool AwakeCondition()
		{
			return false;
		}

		protected override void OnExit()
		{
		}
	}
}
