namespace Assets.Scripts.Core.Skills.Projectiles
{
	public class ProjectileTargetFilterParams
	{
		public readonly int hitboxId;

		public readonly int partId;

		public readonly int rehitRate;

		public readonly int maxEnemyHitCount;

		public readonly int numberOfHit;

		public readonly float intervalBetweenHit;

		public readonly bool hitEnemy;

		public readonly bool hitAlly;

		public ProjectileTargetFilterParams()
		{
		}

		public ProjectileTargetFilterParams(int maxEnemyHitCount, int numberOfHit, float intervalBetweenHit)
		{
		}

		public ProjectileTargetFilterParams(int hitboxId, int partId, int rehitRate, int maxEnemyHitCount, int numberOfHit, float intervalBetweenHit)
		{
		}

		public ProjectileTargetFilterParams(int hitboxId, int partId, int rehitRate, int maxEnemyHitCount, int numberOfHit, float intervalBetweenHit, bool hitEnemy, bool hitAlly)
		{
		}
	}
}
