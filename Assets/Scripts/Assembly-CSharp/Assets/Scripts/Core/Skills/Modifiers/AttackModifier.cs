using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Movement;
using SSAR.Dungeon.Caching;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class AttackModifier : Modifier
	{
		public interface AttackInfo
		{
			float SuccessRate();

			float Duration();

			float Bonus();

			bool ShouldPlayVfx();
		}

		protected AttackInfo info;

		private float elapsed;

		private GameObject vfx;

		private readonly CharacterMediatorComponent characterMediatorComponent;

		private readonly CachingComponent cachingComponent;

		private readonly GameObject targetGameObject;

		private readonly MovementComponent movementComponent;

		protected readonly AttackComponent attackComponent;

		private float attackBonus;

		public AttackModifier(AttackInfo info, Entity target)
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

		protected virtual bool IsEnableVfx()
		{
			return false;
		}
	}
}
