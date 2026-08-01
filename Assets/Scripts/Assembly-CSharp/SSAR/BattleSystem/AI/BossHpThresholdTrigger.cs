using Artemis;

namespace SSAR.BattleSystem.AI
{
	public class BossHpThresholdTrigger : AbsTrigger
	{
		public float hpDrop;

		public float pointDeduct;

		private int count;

		private EntityWorld entityWorld;

		public BossHpThresholdTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
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
