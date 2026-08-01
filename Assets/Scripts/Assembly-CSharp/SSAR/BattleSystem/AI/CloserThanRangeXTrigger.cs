namespace SSAR.BattleSystem.AI
{
	public class CloserThanRangeXTrigger : AbsTrigger
	{
		public float pointPerSeconds;

		public float rangeX;

		public CloserThanRangeXTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
			: base(null, null, null)
		{
		}

		protected override void MapValue()
		{
		}

		public override bool IsTrigger()
		{
			return false;
		}

		public override void OnTrigger(float deltaTime, ref float point)
		{
		}

		private bool isCloser()
		{
			return false;
		}

		private float GetRange()
		{
			return 0f;
		}
	}
}
