using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using SSAR.BattleSystem.Damage;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Character2
{
	public class Character2ComboAttack3 : DefaultMeleeSkill
	{
		private Environment environment;

		private List<EventFrame> processedEventFrames;

		private Dictionary<GameObject, string> sfxByVfxPrefab;

		private string ghostChosenSfxPath;

		private bool ghostSfxPlayed;

		private float ghostSfxFrame;

		public Character2ComboAttack3(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		protected override void PostModifierInfoAddition(EventFrame ef, DamageInfo damageInfo)
		{
		}

		protected override void PlaySfx(EventFrame ef)
		{
		}
	}
}
