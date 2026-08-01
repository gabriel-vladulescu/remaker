namespace SSAR.BattleSystem.AI
{
	public class HpThresholdTrigger : AbsTrigger
	{
		public float hpDrop;

		public float pointDeduct;

		private int count;

		public HpThresholdTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
			: base(null, null, null)
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
