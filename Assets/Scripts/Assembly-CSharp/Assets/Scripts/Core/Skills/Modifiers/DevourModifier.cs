using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class DevourModifier : Modifier
	{
		public interface Info
		{
			float Duration();

			Vector2 RunValue();

			Vector2 DashValue();

			Vector2 JumpValue();

			DirectionMode DirectionMode();
		}

		public enum DirectionMode
		{
			Global = 0,
			UseCasterPosition = 1,
			UseProjectilePostion = 2,
			UseCasterDirection = 3,
			UseProjectileVelocity = 4
		}

		private readonly Info info;

		private readonly Entity caster;

		private readonly Entity target;

		private readonly Vector3 collidedProjectilePosition;

		private readonly Vector3 collidedProjectileVelocity;

		private float elapsed;

		private readonly MovementComponent movementComponent;

		private List<MovementComponent.VelocityModifier> velocityModifiers;

		private static readonly ModifierType[] MODIFIER_CANNOT_DEVOUR;

		public DevourModifier(Info info, Entity caster, Entity target, Vector3 collidedProjectilePosition, Vector3 collidedProjectileVelocity)
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

		private void AddVelocityModifier(Character character, Vector2 configValue, MovementComponent.VelocityModifierType velocityModifierType)
		{
		}

		private Vector2 GetVelocity(Vector2 value, Character character)
		{
			return default(Vector2);
		}

		private bool IsCharacterValidToDevour(Character character)
		{
			return false;
		}
	}
}
