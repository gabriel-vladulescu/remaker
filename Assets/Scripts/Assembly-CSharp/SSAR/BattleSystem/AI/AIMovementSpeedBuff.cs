using Artemis;
using Assets.Scripts.Ssar.Combat.Skills;

namespace SSAR.BattleSystem.AI
{
	public class AIMovementSpeedBuff : AbsAIBuff
	{
		private SkillComponent skillComponent;

		private AIMovementSpeedModifier movementSpeedModifier;

		public AIMovementSpeedBuff(Entity self, AIBuffConfig config)
			: base(null, null)
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

		private float Duration()
		{
			return 0f;
		}
	}
}
