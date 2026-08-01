using CodeStage.AntiCheat.ObscuredTypes;
using SSAR.Equipment.Enum;

namespace Scripts.Config
{
	public class AncientMaterialInfo
	{
		private ObscuredInt mExp;

		public string rarity { get; set; }

		public int exp
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Rarity Rarity => default(Rarity);
	}
}
