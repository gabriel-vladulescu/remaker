using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar.Combat.Skills.Logic.AnimationControl;
using Assets.Scripts.Ssar.Combat.Skills.Logic.Monster75011;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster10001
{
	public class Monster10001Skill2 : Monster75011Skill2
	{
		public class SkillInfo : Info
		{
			public SkillAnimationConfig animationConfig;
		}

		private SkillInfo skillInfo;

		private SkillAnimationController animController;

		public Monster10001Skill2(Dependencies dependencies)
			: base(null)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		public override void OnCast(Character character)
		{
		}
	}
}
