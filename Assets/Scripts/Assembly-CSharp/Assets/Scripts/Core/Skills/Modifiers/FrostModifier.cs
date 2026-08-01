using System.Collections.Generic;
using Artemis;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class FrostModifier : Modifier
	{
		private enum State
		{
			Slow = 0,
			Freeze = 1
		}

		public interface Info
		{
			float Duration();

			float FreezeDuration();

			float SuccessRate();

			float MovementSpeedBonus();

			int FreezeStack();
		}

		private Info info;

		private Entity target;

		private float elapsed;

		private Modifier curseModifier;

		private Modifier freezeModifier;

		private State state;

		private int stack;

		public FrostModifier(Info info, Entity target)
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

		private int GetStack(object[] cookies)
		{
			return 0;
		}
	}
}
