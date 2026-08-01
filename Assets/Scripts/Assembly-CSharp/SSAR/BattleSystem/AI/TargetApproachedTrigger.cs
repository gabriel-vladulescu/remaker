namespace SSAR.BattleSystem.AI
{
	public class TargetApproachedTrigger : AbsTrigger
	{
		public float range;

		public float pointDeduct;

		public TargetApproachedTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
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
