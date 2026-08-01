using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Character2
{
	public class Character2Skill5 : DefaultRangerSkill
	{
		public class Info
		{
			public int[] numberOfProjectile;

			public int[] frame;

			public Vector2[] velocity;

			public Vector2 centerOffset;

			public float amplitude;

			public int density;
		}

		private Info info;

		private EventFrame sampleEventFrame;

		private Dictionary<EventFrame, Vector2> projectilePositionByEventFrame;

		private Dictionary<EventFrame, Vector2> projectileVelocityByEventFrame;

		private float[] pos;

		private List<float> posToFill;

		private int counter;

		public Character2Skill5(Dependencies dependencies)
			: base(null)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		public override void OnCast(Character character)
		{
		}

		public override bool IsInterruptibleWhileChanneling()
		{
			return false;
		}

		protected override void OnProjectileCreated(Projectile projectile, Entity entity)
		{
		}

		private Vector2 RandomPosition(Vector2 velocity)
		{
			return default(Vector2);
		}

		protected virtual Vector2 CenterPivot()
		{
			return default(Vector2);
		}

		private float[] Random(float spawnX, float xAxisAmplitude, int xAxisDensity)
		{
			return null;
		}
	}
}
