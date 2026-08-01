using System.Collections.Generic;
using Assets.Scripts.Core.Skills.Projectiles;
using Assets.Scripts.Utils;

namespace Assets.Scripts.Core.Skills.Parts
{
	public class ProjectilePart
	{
		private class HitLog
		{
			public int hitCount;

			public float lastHitTime;

			public HitLog()
			{
			}

			public HitLog(int hitCount, float lastHitTime)
			{
			}
		}

		private readonly int id;

		private readonly FrameAndSecondsConverter frameConverter;

		private float elapsed;

		private List<Projectile> projectiles;

		private Dictionary<Character, HitLog> charactersAndHitLogs;

		public ProjectilePart(int id)
		{
		}

		public void Add(Projectile projectile)
		{
		}

		public void Remove(Projectile projectile)
		{
		}

		public bool IsEmpty()
		{
			return false;
		}

		public void Destroy()
		{
		}

		public void Update(float dt)
		{
		}

		private void UpdateProjectile(Projectile projectile)
		{
		}

		private bool ValidateTarget(Character target, Projectile projectile)
		{
			return false;
		}

		private bool IsRehitEnabled(Projectile projectile)
		{
			return false;
		}

		private float GetRehitInterval(Projectile projectile)
		{
			return 0f;
		}

		private int ProjectileComparer(Projectile p1, Projectile p2)
		{
			return 0;
		}
	}
}
