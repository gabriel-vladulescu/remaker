using System;
using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class ReduceDamagePercentageModifier : Modifier
	{
		public interface Info
		{
			float Duration();

			float Reduction();
		}

		private Info info;

		private EntityWorld entityWorld;

		private float elapsed;

		private Event event_;

		private bool isFinish;

		public ReduceDamagePercentageModifier(Info info, EntityWorld entityWorld)
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

		private void OnDashEnd(object source, EventArgs args)
		{
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
