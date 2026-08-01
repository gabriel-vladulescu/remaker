namespace SSAR.BattleSystem.AI
{
	public abstract class AbsTrigger
	{
		public AITriggerLevel triggerLevel;

		protected AbsAction action;

		protected ActionTriggerConfig config;

		protected NewMonsterAIComponent aiComponent;

		public AbsTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
		{
		}

		protected virtual void MapValue()
		{
		}

		public abstract bool IsTrigger();

		public abstract void OnTrigger(float deltaTime, ref float point);

		public virtual void OnRemove()
		{
		}
	}
}
