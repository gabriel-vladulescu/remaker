using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Modifiers;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Ancient
{
	public class Ancient7003Skill : DefaultMeleeSkill
	{
		private List<EventFrame> vfxEventFrames;

		private List<GameObject> vfxObjects;

		public Ancient7003Skill(Dependencies dependencies)
			: base(null)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		protected override void OnVfxFollowBonePlayed(EventFrame ef, List<GameObject> vfxs)
		{
		}

		public override void OnSkillCasted(Skill skill)
		{
		}

		private SkillDamageModifier GetCharacterSkillDamageBuff(Character character)
		{
			return null;
		}
	}
}
