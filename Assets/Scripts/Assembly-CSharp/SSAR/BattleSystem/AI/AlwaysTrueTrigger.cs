namespace SSAR.BattleSystem.AI
{
	public class AlwaysTrueTrigger : AbsTrigger
	{
		public AlwaysTrueTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
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
