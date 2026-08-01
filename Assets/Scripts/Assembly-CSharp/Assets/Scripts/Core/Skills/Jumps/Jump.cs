namespace Assets.Scripts.Core.Skills.Jumps
{
	public class Jump
	{
		private EventFrame eventFrame;

		private Character character;

		private float elapsed;

		private int jumpCount;

		private float timeOfNextJump;

		private bool isThisJumpDisabled;

		public Jump(EventFrame eventFrame, Character character)
		{
		}

		public void Update(float dt)
		{
		}

		private void DoJump()
		{
		}

		private bool IsFinish()
		{
			return false;
		}

		public void Interrupt()
		{
		}
	}
}
