using SSAR.BattleSystem.Damage;

namespace SSAR.BattleSystem.AI
{
	public class BeingHitTrigger : AbsTrigger
	{
		public float pointPerHit;

		public BeingHitTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
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

		private void BeDealDamage(int entityId, int casterId, float damage, DamageSource damageSource)
		{
		}
	}
}
