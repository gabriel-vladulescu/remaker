using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Movement;
using SSAR.Dungeon.Caching;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class ShockModifier : Modifier
	{
		public interface ShockInfo
		{
			float SuccessRate();

			float Duration();

			float MovementSpeedBonus();

			float AdditionalDamageAmplifier();
		}

		private ShockInfo shockInfo;

		private readonly Entity caster;

		private readonly Entity target;

		private float elapsed;

		private GameObject vfx;

		private readonly CharacterMediatorComponent characterMediatorComponent;

		private readonly CachingComponent cachingComponent;

		private readonly GameObject targetGameObject;

		private readonly MovementComponent movementComponent;

		private float bonusInLength;

		private MovementComponent.RunSpeedModifier runSpeedModifier;

		private HealthComponent healthComponent;

		public ShockModifier(ShockInfo shockInfo, Entity caster, Entity target)
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

		private void PlayVfx()
		{
		}

		private void ReturnVfxToPool()
		{
		}
	}
}
