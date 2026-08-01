using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.Cache;
using SSAR.BattleSystem.Movement;
using SSAR.Dungeon.Caching;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class KnockbackModifier : Modifier
	{
		public interface DashInfo
		{
			float Distance();

			float Duration();

			void AdjustDistance(float newValue);
		}

		public interface KnockbackInfo
		{
			float SuccessRate();

			DashInfo DashInfo();

			float Level();

			bool ShouldInterruptTargetSkill();

			bool ShouldKnockbackTowardProjectile();

			bool ShouldUseCasterPositionForKnockbackDirection();

			bool AlwaysKnockbackAccordingToCasterFacingDirection();
		}

		private readonly KnockbackInfo knockbackInfo;

		private Vector3 collidedProjectilePosition;

		private readonly Entity caster;

		private readonly CharacterMediatorComponent characterMediatorComponent;

		private readonly MovementComponent movementComponent;

		private CachingComponent cachingComponent;

		private float elapsed;

		private Direction movingDirection;

		private GameObject vfx;

		private GameObject targetGameObject;

		private CacheTemplateArgsComponent cacheTemplateArgsComponent;

		public KnockbackModifier(KnockbackInfo knockbackInfo, Vector3 collidedProjectilePosition, Entity caster, Entity target)
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

		private void PlayVfx()
		{
		}

		private void ReturnVfxToPool()
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

		private bool IsTargetARunningMonster()
		{
			return false;
		}

		private void Log(string methodName, Character character)
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
