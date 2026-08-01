using Assets.Scripts.Utils;

namespace Scripts.Config
{
	public class HeroLevelStats : AbsStats
	{
		public int level { get; set; }

		public int id { get; set; }

		public int groupId { get; set; }

		public string type { get; set; }

		public string aiTag { get; set; }

		[Stat("maxHP", TransferType.PLUS)]
		public double HP { get; set; }

		[Stat("defPw", TransferType.PLUS)]
		public double Def { get; set; }

		[Stat("atkPw", TransferType.PLUS)]
		public double Atk { get; set; }

		[Stat("magicResist", TransferType.PLUS)]
		public double MagicResist { get; set; }

		[Stat("DmgReduction", TransferType.PLUS)]
		public double DamageReduction { get; set; }

		[Stat("DmgBlockPerAttack", TransferType.PLUS)]
		public double DamageBlockPerAttack { get; set; }

		[Stat("MagicDamageBarrier", TransferType.PLUS)]
		public double MagicDamageBarrier { get; set; }

		[Stat("KnockBackWeight", TransferType.PLUS)]
		public double KnockbackWeight { get; set; }

		[Stat("KnockdownWeight", TransferType.PLUS)]
		public double KnockdownWeight { get; set; }

		public double MoveSpeed { get; set; }

		public int expToNextLevel { get; set; }

		public int expNeededToReachLevel { get; set; }

		protected override void Properties2Map()
		{
		}

		public void Clone(HeroLevelStats obj)
		{
		}
	}
}
