using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.Movement;
using SSAR.Dungeon.Caching;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class KnockdownModifier : Modifier
	{
		public interface KnockdownInfo
		{
			float SuccessRate();

			float Level();

			float Height();

			float DurationReachMaxHeight();

			float DurationLandGround();

			float Distance();

			float Duration();

			bool ShouldUseCasterPositionForKnockdownDirection();

			float FloatingDuration();

			bool ShouldPerformBouncing();

			bool ShouldUseCasterFacingDirectionForKnockdownDirection();

			bool ShouldUserProjectileVelocityForKnockdownDirection();
		}

		private KnockdownInfo knockdownInfo;

		private Vector3 collidedProjectilePosition;

		private readonly Vector3 collidedProjectileVelocity;

		private readonly Entity caster;

		private float elapsed;

		private CachingComponent cachingComponent;

		private GameObject targetGameObject;

		private MovementComponent movementComponent;

		private List<KnockdownInfo> knockdownInfos;

		private int count;

		private Character character;

		public KnockdownModifier(KnockdownInfo knockdownInfo, Vector3 collidedProjectilePosition, Vector3 collidedProjectileVelocity, Entity caster, Entity target)
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
	}
}
