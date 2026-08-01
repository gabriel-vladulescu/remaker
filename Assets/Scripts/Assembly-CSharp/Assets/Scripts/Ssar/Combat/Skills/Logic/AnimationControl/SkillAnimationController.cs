using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.AnimationControl
{
	public class SkillAnimationController
	{
		private enum State
		{
			Startup = 0,
			Loop = 1,
			Recovery = 2
		}

		private readonly SkillAnimationConfig animConfig;

		private readonly Character character;

		private State state;

		private float elapsed;

		public SkillAnimationController(SkillAnimationConfig animConfig, Character character)
		{
		}

		public void Update(float dt)
		{
		}
	}
}
