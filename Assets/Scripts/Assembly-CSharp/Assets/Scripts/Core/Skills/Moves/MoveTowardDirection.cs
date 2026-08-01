using UnityEngine;

namespace Assets.Scripts.Core.Skills.Moves
{
	public class MoveTowardDirection
	{
		private Character character;

		private Vector3 direction;

		private float[] speed;

		private float[] duration;

		private float[] distance;

		private bool moveUntilReachTargetPosition;

		private string animationName;

		private string skipAnimationName;

		private Vector3 targetPosition;

		private float elapsed;

		private bool isAnimPlayed;

		private float chosenSpeed;

		private float chosenDuration;

		public float ChosenDuration => 0f;

		public Vector3 Direction => default(Vector3);

		public float ChosenSpeed => 0f;

		public MoveTowardDirection(Character character, Vector3 direction, float[] speed, float[] duration, float[] distance, bool moveUntilReachTargetPosition, bool moveUntilReachBySpeed, string animationName, string skipAnimationName, Vector3 targetPosition)
		{
		}

		public void Update(float dt)
		{
		}

		public void AdjustDirection(Vector3 newValue)
		{
		}

		private static int Index(float[] distance, float d, int index)
		{
			return 0;
		}

		private bool IsFinish()
		{
			return false;
		}
	}
}
