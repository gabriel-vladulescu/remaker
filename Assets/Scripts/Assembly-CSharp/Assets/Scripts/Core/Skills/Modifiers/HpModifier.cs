using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Movement;
using SSAR.Dungeon.Caching;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class HpModifier : Modifier
	{
		public interface HpInfo
		{
			float SuccessRate();

			float Duration();

			float Interval();

			float Percent();
		}

		private HpInfo info;

		private float elapsed;

		private float elapsedSinceLastAddHp;

		private GameObject vfx;

		private readonly CharacterMediatorComponent characterMediatorComponent;

		private readonly CachingComponent cachingComponent;

		private readonly GameObject targetGameObject;

		private readonly MovementComponent movementComponent;

		private readonly HealthComponent healthComponent;

		private readonly Entity entity;

		public HpModifier(HpInfo info, Entity target)
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

		private void Heal()
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
