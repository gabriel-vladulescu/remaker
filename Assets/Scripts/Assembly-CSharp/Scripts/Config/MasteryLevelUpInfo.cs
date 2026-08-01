using CodeStage.AntiCheat.ObscuredTypes;
using Ssar.Rune.Model;

namespace Scripts.Config
{
	public class MasteryLevelUpInfo
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

		public int runeRequire { get; set; }

		public string runeRarity { get; set; }

		public double stat { get; set; }

		public RuneRarity GetRuneRarity()
		{
			return default(RuneRarity);
		}
	}
}
