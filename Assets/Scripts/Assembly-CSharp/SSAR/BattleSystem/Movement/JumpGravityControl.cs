namespace SSAR.BattleSystem.Movement
{
	public class JumpGravityControl : AbsGravityControl
	{
		private float gravityBefore;

		private float gravityAfter;

		private readonly float floatingDuration;

		private float elapsedTime;

		public JumpGravityControl(float gravityBefore, float gravityAfter, float floatingDuration = 0f)
		{
			this.gravityBefore = gravityBefore;
			this.gravityAfter = gravityAfter;
			this.floatingDuration = floatingDuration;
			elapsedTime = 0f;
		}

		public override float CalculateVelocityVertical(float velocityVertical, float deltaTime)
		{
			if (velocityVertical > 0f)
			{
				return velocityVertical - gravityBefore * deltaTime;
			}

			if (floatingDuration > 0f && elapsedTime < floatingDuration)
			{
				elapsedTime += deltaTime;
				return 0f;
			}

			return velocityVertical - gravityAfter * deltaTime;
		}
	}
}
