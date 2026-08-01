using SSAR.BattleSystem.Movement;

namespace Assets.Scripts.Core.Skills.ForceStopMoves
{
	public class ForceStopMove
	{
		private float durationInSeconds;

		private Character caster;

		private MovementComponent movementComponent;

		private float elapsed;

		public ForceStopMove(float durationInSeconds, object entityWorld, Character caster)
		{
		}

		public void Update(float dt)
		{
		}

		public void Interrupt()
		{
		}

		private bool IsFinish()
		{
			return false;
		}
	}
}
