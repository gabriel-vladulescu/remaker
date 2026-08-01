using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Movement;
using SSAR.Dungeon.Caching;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class ColdBurnModifier : Modifier
	{
		public interface Info
		{
			float SuccessRate();

			float Duration();

			float MovementSpeedBonus();

			float BurnInterval();

			float BurnDamageScale();

			bool ShouldPlayVfx();
		}

		private Info info;

		private readonly Entity caster;

		private readonly Entity target;

		private float elapsed;

		private float elapsedSinceLastBurn;

		private GameObject burnVfx;

		private readonly CharacterMediatorComponent characterMediatorComponent;

		private readonly CachingComponent cachingComponent;

		private readonly GameObject targetGameObject;

		private readonly MovementComponent movementComponent;

		private readonly HealthComponent healthComponent;

		private float damage;

		private GameObject movementSpeedVfx;

		private float bonusInLength;

		private MovementComponent.RunSpeedModifier runSpeedModifier;

		private bool shouldDestroyVfx;

		public ColdBurnModifier(Info info, Entity caster, Entity target)
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

		private void UpdateMovementSpeed()
		{
		}

		private void UpdateBurn(float dt)
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

		protected virtual EffectPathIndex GetBurnVfx()
		{
			return default(EffectPathIndex);
		}

		protected virtual string GetEffectPath()
		{
			return null;
		}

		protected virtual DamageType GetDamageType()
		{
			return default(DamageType);
		}

		private void PlayBurnVfx()
		{
		}

		private void ReturnBurnVfxToPool()
		{
		}

		private void PlayMovementSpeedVfx()
		{
		}

		private void ReturnMovementSpeedVfxToPool()
		{
		}
	}
}
