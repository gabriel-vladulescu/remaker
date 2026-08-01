using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Character2
{
	public class Character2Skill3 : DefaultMeleeSkill
	{
		public class Info
		{
			public string castingAnimationOnAir;
		}

		private Info info;

		private SkillConfig skillConfig;

		private List<EventFrame> processedEventFrames;

		public Character2Skill3(Dependencies dependencies)
			: base(null)
		{
		}

		protected override void PlayAnimation(Character character)
		{
		}

		protected override void PostModifierInfoAddition(EventFrame ef, DamageInfo damageInfo)
		{
		}

		public override bool IsInterruptibleWhileChanneling()
		{
			return false;
		}
	}
}
