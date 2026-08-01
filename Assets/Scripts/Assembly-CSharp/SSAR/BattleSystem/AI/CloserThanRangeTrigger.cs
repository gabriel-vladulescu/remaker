namespace SSAR.BattleSystem.AI
{
	public class CloserThanRangeTrigger : AbsTrigger
	{
		public float pointPerSeconds;

		public float range;

		public bool ignoreY;

		public CloserThanRangeTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
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
