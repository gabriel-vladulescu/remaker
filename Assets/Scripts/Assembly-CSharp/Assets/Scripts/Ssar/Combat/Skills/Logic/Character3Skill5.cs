using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class Character3Skill5 : DefaultRangerSkill
	{
		public class StandStillAtFixedPositionTrajectory : Projectile.Trajectory
		{
			private Vector3 pos;

			public StandStillAtFixedPositionTrajectory(Vector3 pos)
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
		}

		public class Character3Skill5Info : Character3Skill2.Character3Skill2Info
		{
			public string onAirAnimation;
		}

		private Character3Skill5Info info;

		private Dictionary<int, GameObject> vfxPrefabsById;

		private Dictionary<int, Vector2> cellsById;

		private Vector2[] cells;

		private int count;

		public Character3Skill5(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		public static void OnDrawGizmos(SkillEventFrameConfig sefc, SkillConfig sc)
		{
		}

		protected override void OnProjectileCreated(Projectile projectile, Entity entity)
		{
		}

		protected override bool ShouldDestroyProjectileOnTargetHit()
		{
			return false;
		}

		protected override bool ShouldDestroyProjectileOnObstacleHit()
		{
			return false;
		}

		private Vector2 UnitLength(Vector2 size, Vector2 columnRow)
		{
			return default(Vector2);
		}
	}
}
