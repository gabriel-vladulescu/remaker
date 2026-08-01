using UnityEngine;

namespace SSAR.BattleSystem.Movement
{
	public class MovementConfigData : SimpleMovementConfigData
	{
		[Header("Jump")]
		public float jumpHeight;

		public float jumpDurationMaxHeight;

		public float jumpDurationLandGround;

		public float jumpDistance;

		public float jumpXSpeed;

		[Header("Dash Jump")]
		public float dashJumpHeight;

		public float dashJumpDurationMaxHeight;

		public float dashJumpDurationLandGround;

		public float dashJumpDistance;

		[Header("Dash")]
		public float dashDistance;

		public float dashDuration;

		public float dashBlendTime;
	}
}
