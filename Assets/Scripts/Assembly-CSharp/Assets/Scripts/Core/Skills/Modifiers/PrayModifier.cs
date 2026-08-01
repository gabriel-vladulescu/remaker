using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Movement;
using SSAR.Dungeon.Caching;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class PrayModifier : Modifier
	{
		public interface PrayInfo
		{
			float Duration();

			float AttackBonus();

			float DefenseBonus();

			float HpBonus();
		}

		protected PrayInfo info;

		private float elapsed;

		private GameObject vfx;

		private readonly CharacterMediatorComponent characterMediatorComponent;

		private readonly CachingComponent cachingComponent;

		protected readonly AttackComponent attackComponent;

		protected readonly HealthComponent healthComponent;

		private float attackBonus;

		private float defBonus;

		private float hpBonus;

		public PrayModifier(PrayInfo info, Entity target)
		{
		}

		public virtual string Name()
		{
			return null;
		}

		public virtual ModifierType Type()
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

		public virtual void OnBeReplaced(Character character)
		{
		}

		public virtual void OnAttach(Character character)
		{
		}

		public virtual void OnDetach(Character character)
		{
		}

		private void ReturnVfxToPool()
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

		private void PlayVfx()
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

		protected virtual bool IsModifierFinish()
		{
			return false;
		}
	}
}
