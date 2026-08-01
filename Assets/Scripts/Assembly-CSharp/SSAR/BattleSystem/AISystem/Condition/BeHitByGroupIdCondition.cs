using SSAR.BattleSystem.AI;
using SSAR.BattleSystem.Damage;

namespace Ssar.BattleSystem.AISystem.Condition
{
	public class BeHitByGroupIdCondition : AbsCondition
	{
		public int groupId;

		public float holdDuration;

		private NewMonsterAIComponent ai;

		private bool behit;

		private float time;

		public BeHitByGroupIdCondition(AbsAction absAction, NewMonsterAIComponent newMonsterAiComponent, ConditionConfig conditionConfig)
			: base(null, null, null)
		{
		}

		private void BeDealDamage(int entityId, int casterId, float damage, DamageSource damageSource)
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
