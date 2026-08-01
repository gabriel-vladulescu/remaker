namespace SSAR.BattleSystem.Movement
{
	public class NoneGravityControl : AbsGravityControl
	{
		public override float CalculateVelocityVertical(float velocityVertical, float deltaTime)
		{
			return 0f;
		}
	}
}
