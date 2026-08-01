using System.Collections.Generic;
using Artemis;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class CcImmuneModifier : Modifier
	{
		public class Info
		{
			private float duration;

			private bool isLifeCycleDependOnParentSkill;

			private bool isPurification;

			private bool enableVfx;

			public float Duration => 0f;

			public bool IsLifeCycleDependOnParentSkill => false;

			public bool IsPurification => false;

			public bool EnableVfx => false;

			public Info(float duration, bool isLifeCycleDependOnParentSkill, bool isPurification, bool enableVfx)
			{
			}
		}

		private Info info;

		private float elapsed;

		private ModifierVfxManager vfxManager;

		public CcImmuneModifier(Info info, Entity target)
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

		private void Deactivate()
		{
		}
	}
}
