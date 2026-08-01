using Assets.Scripts.Core.Skills;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster9002
{
	public class Monster9002Skill2 : DefaultRangerSkill
	{
		public class Info
		{
			public float activateTime;

			public float interval;

			public int waveCount;

			public float offsetX;

			public float rangeX;
		}

		private Info info;

		private EventFrame defaultProjectile;

		private EventFrame effectProjectile;

		private Vector3 targetPos;

		private float interval;

		private int waveIndex;

		public Monster9002Skill2(Dependencies dependencies)
			: base(null)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		public override void OnCast(Character character)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		protected virtual void Activate()
		{
		}

		protected override Vector2 DirectionTowardNearestTarget(Vector3 pivotPosition, bool ignoreTargetY = false)
		{
			return default(Vector2);
		}
	}
}
