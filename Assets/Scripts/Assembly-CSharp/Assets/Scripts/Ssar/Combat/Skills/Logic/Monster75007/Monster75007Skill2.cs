using System.Collections.Generic;
using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster75007
{
	public class Monster75007Skill2 : DefaultMeleeSkill
	{
		public class Info
		{
			public string recoveryAnimationName;

			public float playRecoveryAnimationAt;
		}

		private Info info;

		private List<TimelineEvent> timelineEvents;

		public Monster75007Skill2(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}
	}
}
