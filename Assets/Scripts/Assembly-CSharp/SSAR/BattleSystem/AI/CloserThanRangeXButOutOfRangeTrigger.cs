namespace SSAR.BattleSystem.AI
{
	public class CloserThanRangeXButOutOfRangeTrigger : AbsTrigger
	{
		public float pointPerSeconds;

		public float range;

		public float rangeX;

		public CloserThanRangeXButOutOfRangeTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
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
	}
}
