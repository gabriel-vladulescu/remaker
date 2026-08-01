namespace SSAR.BattleSystem.AI
{
	public class DeductOverTimeTrigger : AbsTrigger
	{
		public float pointPerSeconds;

		public DeductOverTimeTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
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
