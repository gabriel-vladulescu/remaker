namespace SSAR.BattleSystem.Movement
{
	public class JumpData
	{
		public float jumpHeight;

		public float jumpDurationReachMaxHeight;

		public float jumpDistance;

		public float jumpDurationLandGround;

		public JumpData SetData(float jumpHeight, float jumpDurationReachMaxHeight, float jumpDurationLandGround, float jumpDistance)
		{
			this.jumpHeight = jumpHeight;
			this.jumpDurationReachMaxHeight = jumpDurationReachMaxHeight;
			this.jumpDurationLandGround = jumpDurationLandGround;
			this.jumpDistance = jumpDistance;
			return this;
		}

		public float GetGravityFallGround()
		{
			return 2f * jumpHeight / (jumpDurationLandGround * jumpDurationLandGround);
		}

		public float GetGravityJump()
		{
			return 2f * jumpHeight / (jumpDurationReachMaxHeight * jumpDurationReachMaxHeight);
		}

		public float GetVelocityVerticalInitial()
		{
			return GetGravityJump() * jumpDurationReachMaxHeight;
		}

		public float GetVeloticyHorizontalInitial()
		{
			float totalAirTime = jumpDurationReachMaxHeight + jumpDurationLandGround;
			return totalAirTime > 0f ? jumpDistance / totalAirTime : 0f;
		}

		public override string ToString()
		{
			return string.Format("JumpData[height={0}, upDur={1}, downDur={2}, dist={3}]", jumpHeight, jumpDurationReachMaxHeight, jumpDurationLandGround, jumpDistance);
		}
	}
}
