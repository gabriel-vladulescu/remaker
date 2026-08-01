using Artemis;

namespace SSAR.BattleSystem.AI
{
	public class AIIncreaseLocalCooldownBuff : AbsAIBuff
	{
		public ActionName action;

		public int actionId;

		public float cooldown;

		public AIIncreaseLocalCooldownBuff(Entity self, AIBuffConfig config)
			: base(null, null)
		{
		}

		protected override void MapValue(AIBuffConfig config)
		{
		}

		protected override void OnEnter()
		{
		}

		protected override void OnUpdate(float deltaTime)
		{
		}

		protected override void OnExit()
		{
		}
	}
}
