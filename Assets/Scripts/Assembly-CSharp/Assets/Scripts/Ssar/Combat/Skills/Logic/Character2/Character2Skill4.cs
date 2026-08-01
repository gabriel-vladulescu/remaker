namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Character2
{
	public class Character2Skill4 : DefaultRangerSkill
	{
		public class Info
		{
			public string castingAnimationOnAir;
		}

		private Info info;

		private SkillConfig skillConfig;

		public Character2Skill4(Dependencies dependencies)
			: base(null)
		{
		}

		public override bool IsInterruptibleWhileChanneling()
		{
			return false;
		}

		protected override bool IgnoreMinSpeedOnAirForDashes()
		{
			return false;
		}

		protected override CharacterPositionAndFacingDirection SelectCharacterPositionAndFacingDirection()
		{
			return default(CharacterPositionAndFacingDirection);
		}

		protected override void PlayAnimation()
		{
		}
	}
}
