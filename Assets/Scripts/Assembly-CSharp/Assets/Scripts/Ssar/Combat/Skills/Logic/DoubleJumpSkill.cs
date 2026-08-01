using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DoubleJumpSkill : DefaultMeleeSkill
	{
		public class DoubleJumpInfo
		{
			public float jumpHeight;

			public float jumpDurationReachMaxHeight;

			public float jumpDurationLandGround;

			public float jumpDistance;

			public string animation;
		}

		private readonly Dependencies dependencies;

		public DoubleJumpSkill(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		private bool IsJump2()
		{
			return false;
		}

		private void AdjustFrameOfJump2ToZero()
		{
		}

		private void PlayJump2Animation(Character character)
		{
		}
	}
}
