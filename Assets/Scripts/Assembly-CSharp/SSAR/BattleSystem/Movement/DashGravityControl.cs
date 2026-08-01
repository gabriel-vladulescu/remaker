namespace SSAR.BattleSystem.Movement
{
	public class DashGravityControl : AbsGravityControl
	{
		private float blendTime;

		private float time;

		public DashGravityControl(float blendTime)
		{
		}

		public override void Update(float deltaTime)
		{
		}

		public override float CalculateVelocityVertical(float velocityVertical, float deltaTime)
		{
			return 0f;
		}

		public override bool IsExit()
		{
			return false;
		}
	}
}
