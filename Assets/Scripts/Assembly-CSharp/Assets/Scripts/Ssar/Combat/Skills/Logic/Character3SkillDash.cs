using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class Character3SkillDash : DefaultMeleeSkill
	{
		public class Character3SkillDashInfo
		{
			public float invisibleStartTime;

			public float invisibleDuration;
		}

		private Character3SkillDashInfo info;

		private bool isInvisible;

		private bool isFinish;

		private EventFrame vfxFrame;

		public Character3SkillDash(Dependencies dependencies)
			: base(null)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		public override void Interrupt()
		{
		}

		protected override void PlayVfx(EventFrame ef)
		{
		}
	}
}
