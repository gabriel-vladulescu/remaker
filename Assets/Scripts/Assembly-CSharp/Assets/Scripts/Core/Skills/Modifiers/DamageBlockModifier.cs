using System.Collections.Generic;
using Artemis;
using SSAR.Dungeon.Caching;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class DamageBlockModifier : Modifier
	{
		public interface Info
		{
			float SuccessRate();

			float Duration();

			int BlockCount();

			float ReductionByPercentage();
		}

		private Info info;

		private readonly CachingComponent cachingComponent;

		private float elapsed;

		private int hitCount;

		private GameObject vfx;

		public DamageBlockModifier(Info info, Entity target)
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

		public void OnBeHit()
		{
		}

		public int HitCount()
		{
			return 0;
		}

		private void PlayVfx()
		{
		}

		private void ReturnVfxToPool()
		{
		}
	}
}
