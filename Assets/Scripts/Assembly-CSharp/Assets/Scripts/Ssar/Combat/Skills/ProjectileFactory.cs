using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using Assets.Scripts.Ssar.Combat.Effects.Pool;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class ProjectileFactory
	{
		public class DefaultCollider : Assets.Scripts.Core.Skills.Collider
		{
			private Vector3 relativePositionToCharacter;

			private Vector2 dimension;

			private float radius;

			private float relativeEulerAngle;

			private ColliderShape shape;

			private Vector3 worldPos;

			private Quaternion worldRotation;

			public DefaultCollider(Vector3 relativePositionToCharacter, Vector2 dimension, float angle = 0f)
			{
			}

			public DefaultCollider(Vector3 rptc, float r)
			{
			}

			public Vector3 RelativePositionToCharacter()
			{
				return default(Vector3);
			}

			public void SetWorldPosition(Vector3 worldPos)
			{
			}

			public Vector3 WorldPosition()
			{
				return default(Vector3);
			}

			public Vector2 Dimension()
			{
				return default(Vector2);
			}

			public void SetDimension(Vector2 dimension)
			{
			}

			public float RelativeEulerAngle()
			{
				return 0f;
			}

			public Quaternion WorldRotation()
			{
				return default(Quaternion);
			}

			public void SetWorldRotation(float angle)
			{
			}

			public ColliderShape Shape()
			{
				return default(ColliderShape);
			}

			public float Radius()
			{
				return 0f;
			}
		}

		private Assets.Scripts.Core.Skills.Collision collision;

		private EffectPool effectPool;

		public ProjectileFactory(Assets.Scripts.Core.Skills.Collision collision, EffectPool effectPool)
		{
		}

		public Projectile CreateProjectile(Character character, Skill skill, EventFrame ef, Entity projectileEntity, Vector2 velocity, float ttl, Vector3 characterPositionAtTheTimeOfFirstProjectileCreation, Direction characterFacingDirectionAtTheTimeOfFirstProjectileCreation)
		{
			return null;
		}
	}
}
