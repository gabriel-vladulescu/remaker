namespace SSAR.BattleSystem.AI
{
	public class MoveForward2Action : AbsAction
	{
		public bool changeDirectionOneTime;

		private float minRange;

		private int dir;

		public MoveForward2Action(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
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

		protected override void OnChangeToAwake(bool cancelAnimation)
		{
		}

		protected override void OnExcute()
		{
		}

		protected override void OnExcute(float deltaTime)
		{
		}

		protected override void OnExit()
		{
		}

		private int GetDir()
		{
			return 0;
		}
	}
}
