namespace SSAR.BattleSystem.Movement
{
	public class BubbleGravityControl : AbsGravityControl
	{
		private readonly float gravity;

		public BubbleGravityControl(float gravity)
		{
		}

		public override float CalculateVelocityVertical(float velocityVertical, float deltaTime)
		{
			return 0f;
		}
	}
}
