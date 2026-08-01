using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.Movement;
using SSAR.Dungeon.Caching;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class MovementSpeedModifier : Modifier
	{
		public interface MovementSpeedInfo
		{
			float SuccessRate();

			float Duration();

			float Bonus();

			bool ShouldPlayVfx();

			bool IsLifeCycleDependOnParentSkill();
		}

		private MovementSpeedInfo info;

		private float elapsed;

		private GameObject vfx;

		private readonly CharacterMediatorComponent characterMediatorComponent;

		private readonly CachingComponent cachingComponent;

		private readonly GameObject targetGameObject;

		private readonly MovementComponent movementComponent;

		private float bonusInLength;

		private MovementComponent.RunSpeedModifier runSpeedModifier;

		public MovementSpeedModifier(MovementSpeedInfo info, Entity target)
		{
		}

		public string Name()
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

		private void PlayVfx()
		{
		}

		private void ReturnVfxToPool()
		{
		}

		protected virtual bool IsModifierFinish()
		{
			return false;
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
