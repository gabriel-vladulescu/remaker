using CodeStage.AntiCheat.ObscuredTypes;
using Scripts.Ssar.Arena;

namespace Assets.Scripts.Ssar.Dungeon.View
{
	public class ArenaConstantConfig
	{
		public double battleTime;

		public double cooldownRatio;

		public int levelUnlock;

		private ObscuredInt mStamina;

		public int staminaRequire
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int cooldownRefreshLeaderboard { get; set; }

		public int cooldownSaveData { get; set; }

		public string tierEnableRune { get; set; }

		public bool enableRune { get; set; }

		public double timeToAutoSelectRune { get; set; }

		public int skillLevelEnableCooldown { get; set; }

		public ArenaTier GetTierEnableRune()
		{
			return default(ArenaTier);
		}
	}
}
