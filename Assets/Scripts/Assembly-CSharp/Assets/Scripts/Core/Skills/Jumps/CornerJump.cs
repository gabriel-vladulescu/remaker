using Assets.Scripts.Ssar.Combat.Skills;
using SSAR.BattleSystem.System.Input.Model;

namespace Assets.Scripts.Core.Skills.Jumps
{
	public class CornerJump
	{
		private float delay;

		private EventFrame eventFrame;

		private Character character;

		private Environment environment;

		private float elapsed;

		private int jumpCount;

		private bool skillCasted;

		private CharacterInput characterInput;

		private SkillComponent skillComponent;

		private int frameCount;

		private float jumpDuration;

		public CornerJump(EventFrame eventFrame, Character character, Environment environment)
		{
		}

		public void Update(float dt)
		{
		}

		private void DoJump()
		{
		}
	}
}
