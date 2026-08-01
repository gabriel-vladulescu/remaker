using CodeStage.AntiCheat.ObscuredTypes;
using SSAR.Equipment.Enum;

namespace Scripts.Config
{
	public class AncientExpInfo
	{
		private ObscuredInt mSoulRequire;

		public int level { get; set; }

		public int soulRequire
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int materialRequire { get; set; }

		public string materialRarity { get; set; }

		public Rarity Rarity => default(Rarity);
	}
}
