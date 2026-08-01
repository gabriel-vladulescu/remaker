using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Utils
{
	public class RelativePositionFollowCharacterFacingDirection
	{
		private Direction characterCurrentFacingDirection;

		private Vector3 relativePosition;

		private Direction defaultCharacterFacingDirection;

		public RelativePositionFollowCharacterFacingDirection(Direction characterCurrentFacingDirection, Vector3 relativePosition, Direction defaultCharacterFacingDirection = Direction.Left)
		{
		}

		public Vector3 Obtain()
		{
			return default(Vector3);
		}
	}
}
