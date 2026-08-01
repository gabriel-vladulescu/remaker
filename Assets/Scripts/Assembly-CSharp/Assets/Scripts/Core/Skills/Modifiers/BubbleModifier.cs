using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class BubbleModifier : Modifier
	{
		public enum DirectionMode
		{
			Default = 0,
			UseCasterPosition = 1,
			UseProjectilePostion = 2,
			UseCasterDirection = 3,
			UseProjectileVelocity = 4
		}

		public interface Info
		{
			float SuccessRate();

			float Duration();

			float DamageInterval();

			float DamageScale();

			bool ShouldPlayVfx();

			string FxPath();

			DamageType DamageType();

			Vector2 FloatSpeed();

			DirectionMode DirectionMode();
		}

		private class PoisonInfoAdapter : PoisonModifier.Info
		{
			private Info info;

			public PoisonInfoAdapter(Info info)
			{
			}

			public float SuccessRate()
			{
				return 0f;
			}

			public float Duration()
			{
				return 0f;
			}

			public float MovementSpeedBonus()
			{
				return 0f;
			}

			public float DamageInterval()
			{
				return 0f;
			}

			public float DamageScale()
			{
				return 0f;
			}

			public bool ShouldPlayVfx()
			{
				return false;
			}

			public string FxPath()
			{
				return null;
			}

			public DamageType DamageType()
			{
				return default(DamageType);
			}
		}

		private class ShackleInfoAdapter : ShackleModifier.ShackleInfo
		{
			private Info info;

			public ShackleInfoAdapter(Info info)
			{
			}

			public float SuccessRate()
			{
				return 0f;
			}

			public float Duration()
			{
				return 0f;
			}

			public bool PlayVfx()
			{
				return false;
			}

			public string GetVfxPath()
			{
				return null;
			}
		}

		private readonly Info info;

		private readonly Entity caster;

		private readonly Entity target;

		private readonly Vector3 collidedProjectilePosition;

		private readonly Vector3 collidedProjectileVelocity;

		private float elapsed;

		private PoisonModifier poisonModifier;

		private ShackleModifier shackleModifier;

		private readonly CharacterMediatorComponent characterMediatorComponent;

		private readonly MovementComponent movementComponent;

		public BubbleModifier(Info info, Entity caster, Entity target, Vector3 collidedProjectilePosition, Vector3 collidedProjectileVelocity)
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

		private void SetTargetDirection(Character character)
		{
		}
	}
}
