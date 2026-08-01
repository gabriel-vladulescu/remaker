namespace SSAR.BattleSystem.AI
{
	public class DashJumpAction : AbsAction
	{
		public float rate;

		public float[] rangeX;

		public float[] originalDuration;

		private DashJumpEvadeSkillLogic dashJump;

		private float randomRange;

		public DashJumpAction(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
		}

		protected override void MapValue(ActionConfig config)
		{
		}

		protected override void OnChangeToAwake(bool cancelAnimation)
		{
		}

		public override bool AwakeCondition()
		{
			return false;
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

		protected override bool IsExit()
		{
			return false;
		}

		private void ResetRange()
		{
		}
	}
}
