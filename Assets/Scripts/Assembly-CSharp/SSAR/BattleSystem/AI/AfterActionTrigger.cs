namespace SSAR.BattleSystem.AI
{
	public class AfterActionTrigger : AbsTrigger
	{
		public float pointDeduct;

		public int actionId;

		public bool resetCooldown;

		public float newCooldown;

		public AfterActionTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
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
