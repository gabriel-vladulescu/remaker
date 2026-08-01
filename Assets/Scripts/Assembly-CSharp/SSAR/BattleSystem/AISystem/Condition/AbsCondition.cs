using SSAR.BattleSystem.AI;

namespace Ssar.BattleSystem.AISystem.Condition
{
	public abstract class AbsCondition
	{
		public bool require;

		public bool enable;

		public bool resetPoint;

		protected AbsAction absAction;

		protected NewMonsterAIComponent newMonsterAiComponent;

		protected ConditionConfig ConditionConfig;

		public AbsCondition(AbsAction absAction, NewMonsterAIComponent newMonsterAiComponent, ConditionConfig conditionConfig)
		{
		}

		protected virtual void MapValue(ConditionConfig config)
		{
		}

		public abstract void OnChangeToAwake();

		public abstract void OnExcute();

		public abstract void OnExcuteAction(float deltaTime);

		public abstract void OnExcuteOutOfAction(float deltaTime);

		public abstract void OnExitAction();

		public abstract bool IsMeetCondition();
	}
}
