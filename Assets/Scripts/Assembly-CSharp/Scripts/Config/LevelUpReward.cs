using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

namespace Scripts.Config
{
	public class LevelUpReward
	{
		private ObscuredInt mCrystal;

		private ObscuredInt mStamina;

		private ObscuredInt mSoul;

		public int level { get; set; }

		public int crystal
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int stamina
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int soul
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<ItemInfo> Generate()
		{
			return null;
		}
	}
}
