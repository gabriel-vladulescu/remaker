using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Ssar.Combat.Skills;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class SilentModifier : Modifier
	{
		public interface Info
		{
			float SuccessRate();

			float Duration();

			bool PlayVfx();
		}

		private List<string> whiteList;

		private Info info;

		private float elapsed;

		private readonly SkillComponent skillComponent;

		private List<SkillCastingRequirement> skillCastingRequirements;

		private ModifierVfxManager vfxManager;

		private bool initedFx;

		public SilentModifier(Info info, Entity target)
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

		private void Activate(SkillCastingRequirement skillCastingRequirement)
		{
		}

		public void OnDetach(Character character)
		{
		}

		private void Deactive()
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

		private void PlayVfx()
		{
		}
	}
}
