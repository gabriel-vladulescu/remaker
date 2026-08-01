namespace SSAR.BattleSystem.AI
{
	public class VulnerableAction : InteruptAction
	{
		public float rate;

		public float noTargetInRangeX;

		private float vulnerableTime;

		public float[] originalDuration;

		public VulnerableAction(NewMonsterAIComponent aiComponent, ActionConfig config)
			: base(null, null)
		{
		}

		protected override void MapValue(ActionConfig config)
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

		protected override bool IsExit()
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

		private void ResetVulnerableTime()
		{
		}
	}
}
