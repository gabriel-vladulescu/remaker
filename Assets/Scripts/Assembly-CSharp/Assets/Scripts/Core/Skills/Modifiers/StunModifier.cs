using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.Movement;
using SSAR.Dungeon.Caching;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class StunModifier : Modifier
	{
		public interface StunInfo
		{
			float SuccessRate();

			float Duration();

			bool PlayVfx();

			float AnimTransitionTime();
		}

		private StunInfo stunInfo;

		private float elapsed;

		private GameObject vfx;

		private readonly CharacterMediatorComponent characterMediatorComponent;

		private CachingComponent cachingComponent;

		private GameObject targetGameObject;

		private readonly MovementComponent movementComponent;

		private Character targetCharacter;

		private float animTransitionDuration;

		public StunModifier(StunInfo stunInfo, Entity target)
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
