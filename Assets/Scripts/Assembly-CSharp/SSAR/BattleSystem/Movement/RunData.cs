namespace SSAR.BattleSystem.Movement
{
	public class RunData
	{
		public float runSpeed;

		public RunData SetData(float runSpeed)
		{
			this.runSpeed = runSpeed;
			return this;
		}
	}
}
