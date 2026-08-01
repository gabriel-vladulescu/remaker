namespace SSAR.BattleSystem.AI
{
	public class SelfStatusTrigger : AbsTrigger
	{
		public float pointDeduct;

		public SelfStatusTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
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
