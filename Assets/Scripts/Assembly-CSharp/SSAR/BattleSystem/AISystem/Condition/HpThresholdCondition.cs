using SSAR.BattleSystem.AI;
using SSAR.BattleSystem.Damage;

namespace Ssar.BattleSystem.AISystem.Condition
{
	public class HpThresholdCondition : AbsCondition
	{
		public float threshold;

		private HealthComponent healthComponent;

		public HpThresholdCondition(AbsAction absAction, NewMonsterAIComponent newMonsterAiComponent, ConditionConfig conditionConfig)
			: base(null, null, null)
		{
		}

		public override void OnChangeToAwake()
		{
		}

		public override void OnExcute()
		{
		}

		public override void OnExcuteAction(float deltaTime)
		{
		}

		public override void OnExcuteOutOfAction(float deltaTime)
		{
		}

		public override void OnExitAction()
		{
		}

		public override bool IsMeetCondition()
		{
			return false;
		}
	}
}
