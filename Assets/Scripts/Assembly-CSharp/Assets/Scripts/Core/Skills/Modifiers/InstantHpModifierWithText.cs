using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.Damage;
using SSAR.Dungeon.Caching;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class InstantHpModifierWithText : Modifier
	{
		public interface Info
		{
			float Percentage();

			float Point();

			string EffectPath();
		}

		public class HpModiferInfo : Info
		{
			private float percent;

			private float point;

			private string effectPath;

			public HpModiferInfo SetPercent(float percent)
			{
				return null;
			}

			public HpModiferInfo SetPoint(float point)
			{
				return null;
			}

			public HpModiferInfo SetEffectPath(string effectPath)
			{
				return null;
			}

			public float Percentage()
			{
				return 0f;
			}

			public float Point()
			{
				return 0f;
			}

			public string EffectPath()
			{
				return null;
			}
		}

		private Info info;

		private Entity target;

		private HealthComponent healthComponent;

		private CachingComponent cachingComponent;

		private bool playFx;

		private bool enableHud;

		private GameObject vfx;

		public InstantHpModifierWithText(Info info, Entity target, bool playFx, bool enableHUd)
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
