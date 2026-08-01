namespace Assets.Scripts.Core.Skills
{
	public class HitboxParams
	{
		private int id;

		private int partId;

		private int rehitRate;

		private int maxEnemyHitCount;

		private bool hitEnemy;

		private bool hitAlly;

		public int Id => 0;

		public int PartId => 0;

		public int RehitRate => 0;

		public int MaxEnemyHitCount => 0;

		public bool HitEnemy => false;

		public bool HitAlly => false;

		public HitboxParams(int id, int partId, int rehitRate, int maxEnemyHitCount, bool hitEnemy, bool hitAlly)
		{
		}
	}
}
