using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines
{
	public interface Movement
	{
		void Run();

		void Dash();

		float Jump();

		float JumpDuration();

		void ChangePosition(Vector3 newPosition);

		void DisplaceBy(Vector3 displacement);

		void ForceStop();

		void Resume();

		bool IsInTheAir();

		void ChangeJumpXSpeed();

		void ReturnToOriginalRunSpeed();
	}
}
