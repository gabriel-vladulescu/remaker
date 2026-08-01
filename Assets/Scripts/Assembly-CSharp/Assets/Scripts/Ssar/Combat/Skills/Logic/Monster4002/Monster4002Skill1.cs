using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster4002
{
	public class Monster4002Skill1 : DefaultMeleeSkill
	{
		public class SkillInfo
		{
			public float adjustAnimSpdFrom;

			public float adjustAnimSpdTo;

			public float animSpeed;
		}

		private enum State
		{
			Ready = 0,
			Processing = 1,
			Recovery = 2
		}

		private SkillInfo info;

		private State adjustAnimSpdState;

		private float originalAnimSpeed;

		public Monster4002Skill1(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		public override void Interrupt()
		{
		}
	}
}
