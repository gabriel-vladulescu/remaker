using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.Movement;
using SSAR.Dungeon.Caching;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class ImmuneModifier : Modifier
	{
		public interface ImmuneInfo
		{
			float SuccessRate();

			float Duration();

			bool ShouldPlayLoopVfx();

			bool ShouldPlayFlashVfx();

			bool Physical();

			bool Magical();

			bool Pure();

			bool IsLifeCycleDependOnParentSkill();
		}

		private ImmuneInfo immuneInfo;

		private float elapsed;

		private GameObject vfx;

		private readonly CharacterMediatorComponent characterMediatorComponent;

		private readonly CachingComponent cachingComponent;

		private readonly GameObject targetGameObject;

		private CharacterObjectCaching characterObjectCaching;

		private float immuneFlashElapsed;

		private float immuneFlashPeriod;

		public ImmuneModifier(ImmuneInfo immuneInfo, Entity target)
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

		protected virtual bool CheckisFinish()
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

		private void PlayFlashVfx()
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
