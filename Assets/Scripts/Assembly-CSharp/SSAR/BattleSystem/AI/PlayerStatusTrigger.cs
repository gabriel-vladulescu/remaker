using Artemis;

namespace SSAR.BattleSystem.AI
{
	public class PlayerStatusTrigger : AbsTrigger
	{
		public float pointDeduct;

		private Entity entity;

		public PlayerStatusTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
			: base(null, null, null)
		{
		}

		private void DamageCalculationSystemOnOnEntityDie(Entity entity)
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
