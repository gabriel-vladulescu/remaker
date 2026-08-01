using System;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class MoveUsingSpeedConfig
	{
		public string animationName;

		public bool changeFacingDirection;

		public float acceleration;

		public float maxSpeed;

		public float distance;

		public float startSpeed;

		public float delayMove;
	}
}
