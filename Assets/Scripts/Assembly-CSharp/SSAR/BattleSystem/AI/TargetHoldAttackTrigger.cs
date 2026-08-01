namespace SSAR.BattleSystem.AI
{
	public class TargetHoldAttackTrigger : AbsTrigger
	{
		public float pointPerSeconds;

		private string skillId;

		public TargetHoldAttackTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
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
