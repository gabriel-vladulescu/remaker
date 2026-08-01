using Artemis;
using Assets.Scripts.Core.Skills.Modifiers;

namespace SSAR.BattleSystem.AI
{
	public class AIMovementSpeedModifier : MovementSpeedModifier
	{
		private bool isFinish;

		public AIMovementSpeedModifier(MovementSpeedInfo info, Entity target)
			: base(null, null)
		{
		}

		public void ForceExit()
		{
		}

		protected override bool IsModifierFinish()
		{
			return false;
		}
	}
}
