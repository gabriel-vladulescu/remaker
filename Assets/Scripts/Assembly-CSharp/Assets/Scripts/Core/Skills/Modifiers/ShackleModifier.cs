using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.Movement;
using SSAR.Dungeon.Caching;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class ShackleModifier : Modifier
	{
		public interface ShackleInfo
		{
			float SuccessRate();

			float Duration();

			bool PlayVfx();

			string GetVfxPath();
		}

		private ShackleInfo shackleInfo;

		private float elapsed;

		private GameObject vfx;

		private readonly CharacterMediatorComponent characterMediatorComponent;

		private CachingComponent cachingComponent;

		private GameObject targetGameObject;

		private readonly MovementComponent movementComponent;

		public ShackleModifier(ShackleInfo shackleInfo, Entity target)
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

		public virtual void Update(float dt)
		{
		}

		public bool IsBuff()
		{
			return false;
		}

		public virtual void OnReplaceOtherModifiers(Character character, List<Modifier> others)
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

		public virtual bool IsFinish()
		{
			return false;
		}

		public virtual object[] Cookies()
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
