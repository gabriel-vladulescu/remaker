using System.Collections.Generic;
using Artemis;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class ScreamModifier : Modifier
	{
		public interface Info
		{
			float Duration();

			float SuccessRate();

			float MovementSpeedBonus();

			float AttackBonus();

			float DamageMultiplier();
		}

		private Info info;

		private Entity target;

		private Entity caster;

		private float elapsed;

		private Modifier curseModifier;

		private Modifier freezeModifier;

		private bool cursed;

		private bool freeze;

		private bool dealDamage;

		private int screamLevel;

		public ScreamModifier(Info info, Entity target, Entity caster)
		{
		}

		public string Name()
		{
			return null;
		}

		public ModifierType Type()
		{
			return default(ModifierType);
		}

		public float Duration()
		{
			return 0f;
		}

		public void Update(float dt)
		{
		}

		public bool IsBuff()
		{
			return false;
		}

		public void OnReplaceOtherModifiers(Character character, List<Modifier> others)
		{
		}

		public void OnBeReplaced(Character character)
		{
		}

		public void OnAttach(Character character)
		{
		}

		public void OnDetach(Character character)
		{
		}

		public bool IsFinish()
		{
			return false;
		}

		public object[] Cookies()
		{
			return null;
		}

		public float TimeRemaining()
		{
			return 0f;
		}

		public void OnTargetTakingDamage(float damage)
		{
		}

		public void OnCreateAsBuffFromSkill(Skill parentSkill)
		{
		}

		public void OnCharacterDeath(Character deadCharacter)
		{
		}

		private int ScreamLevel(object[] cookies)
		{
			return 0;
		}
	}
}
