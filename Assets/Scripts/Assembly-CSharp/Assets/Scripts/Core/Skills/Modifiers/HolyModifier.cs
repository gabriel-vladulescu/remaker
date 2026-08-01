using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class HolyModifier : Modifier
	{
		public interface Info
		{
			float DamageReduction();

			float AttackBonus();

			float InstantHp();

			float Duration();

			float ScalePower();
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

		private readonly Entity target;

		private float elapsed;

		private AttackComponent attackComponent;

		private HealthComponent healthComponent;

		private AttackModifier attackModifier;

		private InstantHpModifierWithText instantHpModifier;

		private float deltaDamageReduction;

		private float deltaAttack;

		private ModifierVfxManager vfxManager;

		public HolyModifier(Info info, Entity target)
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
