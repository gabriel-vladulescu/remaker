using System;
using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.System.Event.Component;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Character2
{
	public class Character2Skill6 : DefaultMeleeSkill
	{
		private SkillData skillData;

		private int damageFrameCount;

		private List<EventFrame> processedEventFrames;

		private CharacterEvent characterEvent;

		public Character2Skill6(Dependencies dependencies)
			: base(null)
		{
		}

		private void OnFallEnd(object source, EventArgs args)
		{
		}

		private void OnFallEnd2(object source, EventArgs args)
		{
		}

		public override void OnFinish(Character character)
		{
		}

		public override void Interrupt()
		{
		}

		public override void OnCast(Character character)
		{
		}

		public override bool IsInterruptibleWhileChanneling()
		{
			return false;
		}

		protected override void PostModifierInfoAddition(EventFrame ef, DamageInfo damageInfo)
		{
		}
	}
}
