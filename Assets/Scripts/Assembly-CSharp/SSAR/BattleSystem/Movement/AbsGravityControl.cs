namespace SSAR.BattleSystem.Movement
{
	public abstract class AbsGravityControl
	{
		public virtual bool IsExit()
		{
			return false;
		}

		public virtual void Update(float deltaTime)
		{
		}

		public abstract float CalculateVelocityVertical(float velocityVertical, float deltaTime);
	}
}
