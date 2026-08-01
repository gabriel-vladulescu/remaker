using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Ancient
{
	public class Ancient7009Skill : DefaultRangerSkill
	{
		public class SkillInfo
		{
			public float minAmplitude;

			public float maxAmplitude;

			public float minPeriod;

			public float maxPeriod;

			public int randomDensity;

			public float projectileCount;

			public float interval;
		}

		public class CurveTrajectory : Projectile.Trajectory
		{
			private float amplitude;

			private float period;

			private int directionFactor;

			private float elapsed;

			private bool inited;

			private Vector3 originPos;

			public CurveTrajectory(float amplitude, float period, int directionFactor)
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

		private SkillInfo info;

		private EventFrame damageEventFrame;

		private Direction projectileUpDownDirection;

		public Ancient7009Skill(Dependencies dependencies)
			: base(null)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		protected override void OnProjectileCreated(Projectile projectile, Entity entity)
		{
		}
	}
}
