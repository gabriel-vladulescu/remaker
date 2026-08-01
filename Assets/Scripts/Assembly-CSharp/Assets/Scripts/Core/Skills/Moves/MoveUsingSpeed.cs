namespace Assets.Scripts.Core.Skills.Moves
{
	public class MoveUsingSpeed
	{
		private Character character;

		private float acceleration;

		private float startSpeed;

		private float maxSpeed;

		private float distance;

		private float moveDelay;

		private bool changeFacingDirection;

		private string animationName;

		private float duration;

		private float previousSpeed;

		private float traveledDistance;

		private float elapsed;

		private bool isFacingDirectionChanged;

		public MoveUsingSpeed(Character character, float acceleration, float startSpeed, float maxSpeed, float distance, float moveDelay, bool changeFacingDirection, string animationName)
		{
		}

		public void Update(float dt)
		{
		}

		public bool IsFinish()
		{
			return false;
		}

		private void ChangeFacingDirectionToTheOpposite()
		{
		}
	}
}
