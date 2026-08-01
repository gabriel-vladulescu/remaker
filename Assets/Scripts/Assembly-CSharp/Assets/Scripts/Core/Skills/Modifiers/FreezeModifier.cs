using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.Movement;
using SSAR.Dungeon.Caching;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class FreezeModifier : Modifier
	{
		public interface Info
		{
			float Duration();

			float SuccessRate();

			bool ShouldPlayMaterialVfx();

			bool ShouldPlayLockVfx();
		}

		private Info info;

		private float elapsed;

		private GameObject vfx;

		private readonly CharacterMediatorComponent characterMediatorComponent;

		private CachingComponent cachingComponent;

		private GameObject targetGameObject;

		private readonly MovementComponent movementComponent;

		public FreezeModifier(Info info, Entity target)
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

		private void ReplaceMaterial()
		{
		}

		private void RestoreMaterial()
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
