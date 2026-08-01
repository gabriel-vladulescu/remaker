namespace SSAR.BattleSystem.Movement
{
	public class DefaultGravityControl : AbsGravityControl
	{
		private float gravity;

		public DefaultGravityControl(float gravity)
		{
			this.gravity = gravity;
		}

		public override float CalculateVelocityVertical(float velocityVertical, float deltaTime)
		{
			return velocityVertical - gravity * deltaTime;
		}
	}
}
