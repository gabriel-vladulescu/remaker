using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster4003
{
	public class Monster4003Skill1 : DefaultMeleeSkill
	{
		public class SkillInfo
		{
			public float slowFrom;

			public float slowTo;

			public float slowSpeed;

			public float attackTime;

			public float recoveryTime;

			public string attackAnim;

			public string recoveryAnim;
		}

		private enum State
		{
			Ready = 0,
			Processing = 1,
			Recovery = 2
		}

		private SkillInfo info;

		private State jumpState;

		private State slowAnimState;

		private float originalAnimSpeed;

		public Monster4003Skill1(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		public override void OnFinish(Character character)
		{
		}

		public override void Interrupt()
		{
		}

		private void CacheData()
		{
		}
	}
}
