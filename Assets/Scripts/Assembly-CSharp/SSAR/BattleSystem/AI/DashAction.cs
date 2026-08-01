namespace SSAR.BattleSystem.AI
{
	public class DashAction : AbsAction
	{
		public bool checkisInFrontOf;

		public float noTargetInRangeX;

		public float[] originalDuration;

		private DashEvadeSkillLogic dashEvadeSkillLogic;

		public DashAction(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
		}

		protected override void OnChangeToAwake(bool cancelAnimation)
		{
		}

		protected override void OnExcute()
		{
		}

		protected override bool IsEnable()
		{
			return false;
		}

		public override bool AwakeCondition()
		{
			return false;
		}

		protected override void OnExcute(float deltaTime)
		{
		}

		protected override void OnExit()
		{
		}

		protected override bool IsExit()
		{
			return false;
		}

		private bool CheckIsInFrontOfValid()
		{
			return false;
		}

		private bool IsTargetInFrontOf()
		{
			return false;
		}
	}
}
