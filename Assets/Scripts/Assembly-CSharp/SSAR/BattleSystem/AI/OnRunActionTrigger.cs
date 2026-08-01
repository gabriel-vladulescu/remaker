namespace SSAR.BattleSystem.AI
{
	public class OnRunActionTrigger : AbsTrigger
	{
		public float rate;

		public int actionId;

		public float pointDeduct;

		public OnRunActionTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
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
