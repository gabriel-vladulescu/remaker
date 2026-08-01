namespace SSAR.BattleSystem.AI
{
	public class MissedAttackTrigger : AbsTrigger
	{
		private bool attackMiss;

		public float pointPerHit;

		public MissedAttackTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
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

		private void OnEntityDealDamage(int entityId, float damage)
		{
		}
	}
}
