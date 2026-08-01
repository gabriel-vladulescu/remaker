namespace Assets.Scripts.Core.Skills
{
	public class MoveUsingSpeed
	{
		private string animationName;

		private bool changeFacingDirection;

		private float acceleration;

		private float maxSpeed;

		private float distance;

		private float startSpeed;

		private float delayMove;

		public string AnimationName => null;

		public bool ChangeFacingDirection => false;

		public float Acceleration => 0f;

		public float MaxSpeed => 0f;

		public float Distance => 0f;

		public float StartSpeed => 0f;

		public float DelayMove => 0f;

		public MoveUsingSpeed(string animationName, bool changeFacingDirection, float acceleration, float startSpeed, float maxSpeed, float distance, float delayMove)
		{
		}
	}
}
