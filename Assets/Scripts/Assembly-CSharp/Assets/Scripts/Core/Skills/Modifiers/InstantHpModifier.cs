using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.Damage;
using SSAR.Dungeon.Caching;
using SSAR.Dungeon.HUD;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class InstantHpModifier : Modifier
	{
		public interface Info
		{
			float Percentage();

			float Point();

			string EffectPath();
		}

		private Info info;

		private Entity target;

		private HealthComponent healthComponent;

		private CachingComponent cachingComponent;

		private HUDMediatorComponent hudMediatorComponent;

		private GameObject vfx;

		public InstantHpModifier(Info info, Entity target)
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

		private Vector3 VfxPosition()
		{
			return default(Vector3);
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
