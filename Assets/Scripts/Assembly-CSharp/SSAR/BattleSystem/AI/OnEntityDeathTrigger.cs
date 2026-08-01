using Artemis;

namespace SSAR.BattleSystem.AI
{
	public class OnEntityDeathTrigger : AbsTrigger
	{
		public int entityGroupId;

		public float pointDeduct;

		public OnEntityDeathTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
			: base(null, null, null)
		{
		}

		private void DamageCalculationSystemOnEntityDeathEvent(Entity entity)
		{
		}

		public override void OnRemove()
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
