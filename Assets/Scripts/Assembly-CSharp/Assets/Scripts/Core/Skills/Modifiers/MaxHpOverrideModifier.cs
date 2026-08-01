using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class MaxHpOverrideModifier : Modifier
	{
		public interface Info
		{
			float Duration();

			float Percentage();
		}

		private Info info;

		private Entity target;

		private readonly bool autoRecoveryFullHp;

		private float elapsed;

		private HealthComponent healthComponent;

		private float healthBonus;

		public MaxHpOverrideModifier(Info info, Entity target, bool autoRecoveryFullHp)
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
	}
}
