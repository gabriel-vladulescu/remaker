using SSAR.BattleSystem.Damage;

namespace SSAR.BattleSystem.AI
{
	public class HpLostTrigger : AbsTrigger
	{
		public float pointDeduct;

		public float hpLost;

		private bool flag;

		private float hp;

		public HpLostTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
			: base(null, null, null)
		{
		}

		private void DamageCalculationSystemOnOnEntityBeDealDamage(int id, int casterId, float damage, DamageSource damageSource)
		{
		}

		public override bool IsTrigger()
		{
			return false;
		}

		public override void OnTrigger(float deltaTime, ref float point)
		{
		}

		public override void OnRemove()
		{
		}
	}
}
