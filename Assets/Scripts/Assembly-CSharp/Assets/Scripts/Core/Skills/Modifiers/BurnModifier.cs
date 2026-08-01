using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Movement;
using SSAR.Dungeon.Caching;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class BurnModifier : Modifier
	{
		public interface BurnInfo
		{
			float SuccessRate();

			float Duration();

			float Interval();

			float DamageScale();

			bool ShouldPlayVfx();
		}

		private BurnInfo info;

		private readonly Entity caster;

		private readonly Entity target;

		private float elapsed;

		private float elapsedSinceLastBurn;

		private GameObject vfx;

		private readonly CharacterMediatorComponent characterMediatorComponent;

		private readonly CachingComponent cachingComponent;

		private readonly GameObject targetGameObject;

		private readonly MovementComponent movementComponent;

		private readonly HealthComponent healthComponent;

		private float damage;

		public BurnModifier(BurnInfo info, Entity caster, Entity target)
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

		public void OnReplaceOtherModifiers(Character character, List<Modifier> others)
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

		public bool IsFinish()
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

		public void OnTargetTakingDamage(float damage1)
		{
		}

		public void OnCreateAsBuffFromSkill(Skill parentSkill)
		{
		}

		public void OnCharacterDeath(Character deadCharacter)
		{
		}

		protected virtual DamageType ShowDamageType()
		{
			return default(DamageType);
		}
	}
}
