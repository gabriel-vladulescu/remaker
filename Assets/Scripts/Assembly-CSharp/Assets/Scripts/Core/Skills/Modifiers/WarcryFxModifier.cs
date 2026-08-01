using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.Damage;
using SSAR.Dungeon.Caching;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class WarcryFxModifier : Modifier
	{
		public interface Info
		{
			float DefBonus();

			float AtkBonus();

			float Duration();

			float ScalePower();

			string StartupFxPath();

			string ActiveFxPath();

			Vector3 Offset();

			Vector3 Scale();
		}

		private readonly Info info;

		private readonly Entity target;

		private float elapsed;

		private CachingComponent cachingComponent;

		private AttackComponent attackComponent;

		private HealthComponent healthComponent;

		private float deltaAtk;

		private float deltaDef;

		private GameObject startupVfx;

		private GameObject activeVfx;

		public WarcryFxModifier(Info info, Entity target)
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

		private GameObject PlayVfx(string path)
		{
			return null;
		}

		private void UpdateVfx(GameObject vfx)
		{
		}

		private void ReturnVfxToPool(GameObject vfx)
		{
		}
	}
}
