using System;
using Assets.Scripts.Utils;

namespace Scripts.Config
{
	public class HeroBasicStats : AbsStats, ICloneable
	{
		public int id { get; set; }

		public int groupId { get; set; }

		public string name { get; set; }

		[Stat("critchance", TransferType.PLUS)]
		public double CritChance { get; set; }

		[Stat("critDamage", TransferType.PLUS)]
		public double CritDamage { get; set; }

		[Stat("magicResist", TransferType.PLUS)]
		public double MagicResist { get; set; }

		[Stat("DmgReduction", TransferType.PLUS)]
		public double DamageReduction { get; set; }

		[Stat("DmgBlockPerAttack", TransferType.PLUS)]
		public double DamageBlockPerAttack { get; set; }

		[Stat("MagicDamageBarrier", TransferType.PLUS)]
		public double MagicDamageBarrier { get; set; }

		[Stat("DmgAmplification", TransferType.PLUS)]
		public double DamageAmplification { get; set; }

		[Stat("KnockBackWeight", TransferType.PLUS)]
		public double KnockbackWeight { get; set; }

		[Stat("KnockdownWeight", TransferType.PLUS)]
		public double KnockdownWeight { get; set; }

		[Stat("atkSpd", TransferType.PLUS)]
		public double AtkSpd { get; set; }

		[Stat("movSpd", TransferType.PLUS)]
		public double MovSpd { get; set; }

		[Stat("dodgeChance", TransferType.PLUS)]
		public double DodgeChance { get; set; }

		[Stat("skillCritChance", TransferType.PLUS)]
		public double skillCritChance { get; set; }

		[Stat("skillCritDamage", TransferType.PLUS)]
		public double skillCritDamage { get; set; }

		[Stat("bonusDamagePvp", TransferType.PLUS)]
		public double bonusDamagePvp { get; set; }

		[Stat("BlockChance", TransferType.PLUS)]
		public double BlockChance { get; set; }

		public double rotateZ { get; set; }

		public bool keepCorpseWhenDie { get; set; }

		public bool movable { get; set; }

		public bool beatable { get; set; }

		public bool clampPositionToGround { get; set; }

		public double offsetZ { get; set; }

		protected override void Properties2Map()
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
