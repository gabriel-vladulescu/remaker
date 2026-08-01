using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Model;

namespace Scripts.Config
{
	public class RaidBossConfig : IConfig
	{
		public class Constants
		{
			public float cooldownSaveData;

			public float cooldownRefreshLeaderboard;

			public float cooldownRefreshGlobalProgress;

			public bool enableResurrectionInDungeon { get; set; }

			public bool disablePetAfterCharacterDie { get; set; }

			public string highestDifficulty { get; set; }

			public int currentLabId { get; set; }

			public int maxContributor { get; set; }

			public bool disableSingleModeReward { get; set; }

			public bool enableLimitedEntries { get; set; }

			public bool enableDifficultyEntry { get; set; }

			public int freeEntriesPerDay { get; set; }

			public int maxDailyEntry { get; set; }

			public float scaleReward { get; set; }

			public int[] dropRewardQuantityRange { get; set; }

			public ScenarioDifficulty GetHighestDifficulty()
			{
				return default(ScenarioDifficulty);
			}
		}

		public class Entry
		{
			public int entry { get; set; }

			public int cost { get; set; }
		}

		public class Lab
		{
			public int id;

			public string name;

			public int order;
		}

		public class Room : IDungeonInfo
		{
			public int timeRequire;

			public int staminaRequire;

			public int id { get; set; }

			public string cameraId { get; set; }

			public string terrainId { get; set; }

			public string terrainColliderId { get; set; }

			public string stageCameraId { get; set; }

			public string heroSpawnLocation { get; set; }

			public int[] stageIds { get; set; }

			public int[] gateIds { get; set; }

			public int[] stageActivatorIds { get; set; }

			public string nodeSpawner { get; set; }

			public string movementInfluenceId { get; set; }

			public string difficulty { get; set; }

			public int nodeOrder { get; set; }

			public int mapId { get; set; }

			public int maxPotion { get; set; }

			public int limitTryPerDay { get; set; }

			public int baseGlobalKill { get; set; }

			public int powerSuggestion { get; set; }

			public ScenarioDifficulty GetDifficulty()
			{
				return default(ScenarioDifficulty);
			}

			public bool MayMimicAppear()
			{
				return false;
			}

			public float MimicAppearRate()
			{
				return 0f;
			}

			public string MimicId()
			{
				return null;
			}
		}

		public class BattleReward
		{
			public int rank { get; set; }

			public int id { get; set; }

			public string rewardType { get; set; }

			public int configId { get; set; }

			public int quantity { get; set; }

			public int step { get; set; }

			public int guarantee { get; set; }

			public ItemType GetItemType()
			{
				return default(ItemType);
			}

			public ItemInfo ParseToItemInfo()
			{
				return null;
			}

			public bool IsGuarantee()
			{
				return false;
			}

			public static int Comparer(BattleReward a, BattleReward b)
			{
				return 0;
			}
		}

		public class SeasonalRankRewardValue
		{
			private bool isLastRank;

			public string difficulty { get; set; }

			public int lowestRank { get; set; }

			public int cosmeticCard { get; set; }

			public int equipmentCard { get; set; }

			public int runeCard { get; set; }

			public int petCard { get; set; }

			public int crystal { get; set; }

			public int soul { get; set; }

			public int craftingMaterial { get; set; }

			public bool IsLastRank => false;

			public ScenarioDifficulty GetDifficulty()
			{
				return default(ScenarioDifficulty);
			}

			public void SetAsLastRank()
			{
			}
		}

		public class SeasonalRankRewardId
		{
			private bool isLastRank;

			public int cosmeticCard { get; set; }

			public int equipmentCard { get; set; }

			public int runeCard { get; set; }

			public int petCard { get; set; }

			public int craftingMaterial { get; set; }

			public string difficulty { get; set; }

			public int lowestRank { get; set; }

			public bool IsLastRank => false;

			public ScenarioDifficulty GetDifficulty()
			{
				return default(ScenarioDifficulty);
			}

			public void SetAsLastRank()
			{
			}
		}

		public class RaidMonsterLevelStats
		{
			public int level { get; set; }

			public int id { get; set; }

			public int groupId { get; set; }

			public string type { get; set; }

			public string aiTag { get; set; }

			public int hitCountToKillHero { get; set; }

			public int step_kill_hero { get; set; }

			public int hitCountUntilDie { get; set; }

			public int step_until_die { get; set; }

			public double physicalDmgReduction { get; set; }

			public double magicDmgReduction { get; set; }

			public double scale { get; set; }

			public double DamageReduction { get; set; }

			public double MagicDamageBarrier { get; set; }

			public double DamageBlockPerAttack { get; set; }

			public double KnockbackWeight { get; set; }

			public double KnockdownWeight { get; set; }

			public double MoveSpeed { get; set; }
		}

		public class GlobalReward
		{
			public int rewardId { get; set; }

			public string difficulty { get; set; }

			public int killThreshold { get; set; }

			public int minRequireKill { get; set; }

			public double rewardScale { get; set; }

			public double checkpointRewardScale { get; set; }

			public int checkpointRewardQuantity { get; set; }

			public double RewardScale => 0.0;

			public ScenarioDifficulty GetDifficulty()
			{
				return default(ScenarioDifficulty);
			}
		}

		public Dictionary<string, Constants> constants;

		public Dictionary<string, Entry> entries;

		public Dictionary<string, Lab> labs;

		public Dictionary<string, Room> rooms;

		public Dictionary<string, Stage> stages;

		public Dictionary<string, GlobalReward> globalKillRewards;

		private Dictionary<ScenarioDifficulty, Dictionary<string, RaidMonsterLevelStats>> monsterStats;

		private Dictionary<ScenarioDifficulty, Dictionary<string, BattleReward>> rewards;

		private Dictionary<int, Dictionary<ScenarioDifficulty, List<SeasonalRankRewardValue>>> seasonalRewardValues;

		private Dictionary<int, Dictionary<ScenarioDifficulty, List<SeasonalRankRewardId>>> seasonalRewardIds;

		private List<string> dicBehaviour;

		private List<string> categories;

		public void OnMapValue(string content)
		{
		}

		public Constants GetConfigConstants()
		{
			return null;
		}

		public Lab GetLabById(int labId)
		{
			return null;
		}

		public Lab GetLabByOrder(int order)
		{
			return null;
		}

		public Room GetRoomByLabAndDifficulty(int labId, ScenarioDifficulty difficulty)
		{
			return null;
		}

		public bool FindRoomById(int id, ref Room room)
		{
			return false;
		}

		public bool FindStageById(int id, ref Stage stage)
		{
			return false;
		}

		public RaidMonsterLevelStats FindMonsterStats(int groupId, int id, int level, ScenarioDifficulty difficulty)
		{
			return null;
		}

		public BattleReward[] FindBattleRewards(ScenarioDifficulty difficulty, int rank = 1, int maxRewardTypeCount = -1)
		{
			return null;
		}

		public List<string> GetListBehaviour()
		{
			return null;
		}

		public List<string> GetCategoriesBahaviour()
		{
			return null;
		}

		public List<SeasonalRankRewardValue> GetLeagueRewards(ScenarioDifficulty difficulty, int seasonId)
		{
			return null;
		}

		public List<ItemInfo> GetItemInfos(SeasonalRankRewardValue seasonalRankRewardValue, int seasonId)
		{
			return null;
		}

		public List<ItemInfo> GetSeasonalRewardItemInfos(ScenarioDifficulty difficulty, int seasonId, int rank)
		{
			return null;
		}

		public SeasonalRankRewardValue GetSeasonalRankRewardValue(ScenarioDifficulty difficulty, int seasonId, int rank)
		{
			return null;
		}

		public List<GlobalReward> GetGlobalRewards(ScenarioDifficulty difficulty)
		{
			return null;
		}

		public List<GlobalReward> GetGlobalRewardsByKill(ScenarioDifficulty difficulty, int globalKill)
		{
			return null;
		}

		public GlobalReward GetMaxGlobalReward(ScenarioDifficulty difficulty)
		{
			return null;
		}

		public GlobalReward GetGlobalReward(ScenarioDifficulty difficulty, int rewardId)
		{
			return null;
		}

		public Entry GetEntry(int entryCount)
		{
			return null;
		}

		private void Setup(string content)
		{
		}

		private Dictionary<string, RaidMonsterLevelStats> GetDictMonsterStats(ScenarioDifficulty difficulty)
		{
			return null;
		}

		private Dictionary<string, BattleReward> GetDictBattleRewards(ScenarioDifficulty difficulty)
		{
			return null;
		}

		private Dictionary<ScenarioDifficulty, List<SeasonalRankRewardValue>> GetDictSeasonalRewardValues(int seasonId)
		{
			return null;
		}

		private Dictionary<ScenarioDifficulty, List<SeasonalRankRewardId>> GetDictSeasonalRewardIds(int seasonId)
		{
			return null;
		}

		public List<SeasonalRankRewardId> GetSeasonalRewardIds(ScenarioDifficulty difficulty, int seasonId)
		{
			return null;
		}

		private SeasonalRankRewardId GetSeasonalRankRewardId(SeasonalRankRewardValue seasonalRankRewardValue, int seasonId)
		{
			return null;
		}
	}
}
