using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Modifiers;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Effect;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public static class SkillUtils
	{
		public static Character[] FindTargetsPosition(Environment environment, Character caster, float radiusToFindTarget, AutoFindTargetMode autoFindTargetMode, int numberOfTarget = -1)
		{
			return null;
		}

		public static Character[] FindTargetsPosition(Environment environment, Character caster, Vector3 centerPosition, float radiusToFindTarget, AutoFindTargetMode autoFindTargetMode, int numberOfTarget = -1)
		{
			return null;
		}

		public static float RandomAmplitudeScale(float baseValue, float amplitudeScale, int density)
		{
			return 0f;
		}

		public static float RandomAmplitude(float baseValue, float amplitude, int density)
		{
			return 0f;
		}

		public static bool IsCharacterDamageImmune(Character character)
		{
			return false;
		}

		public static Vector3 GetPos(Entity e, StatusEffectLayer posOnBody)
		{
			return default(Vector3);
		}

		public static ShackleModifier GetCharacterShackle(Character character)
		{
			return null;
		}

		public static Modifier GetCharacterModifier(Character character, Assets.Scripts.Core.Skills.Modifiers.ModifierType type)
		{
			return null;
		}

		public static bool IsTargetHasCC(Character target, Assets.Scripts.Core.Skills.Modifiers.ModifierType modifierType)
		{
			return false;
		}

		public static Vector2 GetMapCenterPosition(Environment environment)
		{
			return default(Vector2);
		}

		public static EventFrame GetEventFrameOfProjectile(Projectile projectile)
		{
			return null;
		}

		public static bool IsCharacterChannelingActiveSkill(Character character)
		{
			return false;
		}

		public static ITrajectoryConfig DeserializeTrajectoryConfig(ProjectileTrajectoryType type, string configString)
		{
			return null;
		}

		public static Projectile.Trajectory GetTrajectory(Skill skill, ProjectileTrajectoryParams trajectoryParams, Direction direction)
		{
			return null;
		}
	}
}
