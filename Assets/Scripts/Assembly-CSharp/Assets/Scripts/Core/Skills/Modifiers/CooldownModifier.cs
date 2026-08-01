using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Ssar.Combat.Skills;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class CooldownModifier : Modifier
	{
		public interface Info
		{
			float SuccessRate();

			Mode Mode();

			float Percentage();

			float RawValue();

			bool ShouldPlayVfx();

			string Source();
		}

		public enum Mode
		{
			Percentage = 0,
			RawValue = 1
		}

		private Info info;

		private SkillComponent skillComponent;

		public CooldownModifier(Info info, Entity target)
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

		private void ModifyCooldown(SkillCastingRequirement skillCastingReq)
		{
		}
	}
}
