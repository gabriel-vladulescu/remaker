using System.Collections.Generic;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class DamageImmuneModifier : Modifier
	{
		public class Info
		{
			private float duration;

			private bool isLifeCycleDependOnParentSkill;

			public float Duration => 0f;

			public bool IsLifeCycleDependOnParentSkill => false;

			public Info(float duration, bool isLifeCycleDependOnParentSkill)
			{
			}
		}

		private Info info;

		private float elapsed;

		public DamageImmuneModifier(Info info)
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
