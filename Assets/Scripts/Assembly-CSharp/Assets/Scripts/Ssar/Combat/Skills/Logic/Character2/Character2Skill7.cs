using Artemis;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Character2
{
	public class Character2Skill7 : DefaultRangerSkill
	{
		public class BoomerangTrajectory : Projectile.Trajectory, DefaultRangerProjectile.LifeCycle
		{
			private readonly float ttl;

			private readonly Vector2 initialVelocity;

			private float elapsed;

			private float lastEasingValue;

			private bool isReturnedToThrower;

			private Vector2 previousPosition;

			private bool finish;

			public BoomerangTrajectory(float ttl, Vector2 initialVelocity)
			{
			}

			public Direction AdjustCharacterFacingDirectionParam(Direction currentDirection, Direction directionAtTheTimeOfFirstProjectileCreation)
			{
				return default(Direction);
			}

			public Vector3 AdjustCharacterPositionParam(Vector3 currentCharacterPosition, Vector3 characterPositionAtTheTimeOfFirstProjectileCreation)
			{
				return default(Vector3);
			}

			public void Update(float dt, Projectile projectile, Vector3 currentPosition)
			{
			}

			public bool End()
			{
				return false;
			}
		}

		public Character2Skill7(Dependencies dependencies)
			: base(null)
		{
		}

		protected override void OnProjectileCreated(Projectile projectile, Entity entity)
		{
		}
	}
}
