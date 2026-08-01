using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.Damage;
using SSAR.Dungeon.Caching;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class ArenaRuneHealthModifier : Modifier
	{
		public interface HpInfo
		{
			float SuccessRate();

			float Duration();

			float Interval();

			float Percent();

			float DisableTime();
		}

		private HpInfo info;

		private float elapsed;

		private float elapsedSinceLastAddHp;

		private GameObject vfx;

		private readonly CachingComponent cachingComponent;

		private readonly HealthComponent healthComponent;

		private readonly Entity entity;

		private float disableTime;

		private float originalMaxHealth;

		public ArenaRuneHealthModifier(HpInfo info, Entity target)
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
