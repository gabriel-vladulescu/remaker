using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Character4
{
	public class Character4Dash : DefaultMeleeSkill
	{
		public class Character4DashInfo
		{
			public string inairDashAnimationName;
		}

		private Character4DashInfo dashInfo;

		public Character4Dash(Dependencies dependencies)
			: base(null)
		{
		}

		protected override void PlayAnimation(Character character)
		{
		}

		protected override void PlaySfxRandomly(EventFrame ef)
		{
		}

		protected override void Move(float dt, float elapsed, EventFrame ef)
		{
		}
	}
}
