using Assets.Scripts.Ssar.Combat.HeroStateMachines;
using UnityEngine;

namespace Assets.UnitTest.Scripts.Ssar.Combat
{
	internal class TestMovement : Movement
	{
		public void Run()
		{
		}

		public void Dash()
		{
		}

		public float Jump()
		{
			return 0f;
		}

		public float JumpDuration()
		{
			return 0f;
		}

		public void ChangePosition(Vector3 newPosition)
		{
		}

		public void DisplaceBy(Vector3 displacement)
		{
		}

		public void ForceStop()
		{
		}

		public void Resume()
		{
		}

		public bool IsInTheAir()
		{
			return false;
		}

		public void ChangeJumpXSpeed()
		{
		}

		public void ReturnToOriginalRunSpeed()
		{
		}
	}
}
