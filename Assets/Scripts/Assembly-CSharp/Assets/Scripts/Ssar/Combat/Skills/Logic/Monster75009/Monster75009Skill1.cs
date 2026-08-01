using System.Collections.Generic;
using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster75009
{
	public class Monster75009Skill1 : DefaultMeleeSkill
	{
		public class Info
		{
			public string prefix;

			public int fromIndex;

			public int toIndex;
		}

		public Info info;

		public List<EventFrame> vfxEventFrames;

		public Monster75009Skill1(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}
	}
}
