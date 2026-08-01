using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class BlessModifier : Modifier
	{
		public interface Info
		{
			float AtkBonus();

			float DefBonus();

			float HealBonus();

			float ScalePower();

			float Duration();
		}

		private class InstantHpInfoImpl : InstantHpModifierWithText.Info
		{
			private float point;

			public InstantHpInfoImpl(float point)
			{
			}

			public float Percentage()
			{
				return 0f;
			}

			public float Point()
			{
				return 0f;
			}

			public string EffectPath()
			{
				return null;
			}
		}

		private Info info;

		private Entity target;

		private float elapsed;

		private InstantHpModifierWithText instantHpModifier;

		private float deltaDef;

		private float deltaAtk;

		private ModifierVfxManager vfxManager;

		private AttackComponent attackComponent;

		private HealthComponent healthComponent;

		public BlessModifier(Info info, Entity target)
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
