using Assets.Scripts.Ssar.Dungeon.Model;
using CodeStage.AntiCheat.ObscuredTypes;

namespace Scripts.Config
{
	public class BloodyTowerFloorInfo : IDungeonInfo
	{
		public int floor;

		public int timeRequire;

		private ObscuredInt mStamina;

		private ObscuredInt mReward1Star;

		private ObscuredInt mReward2Star;

		private ObscuredInt mReward3Star;

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

		public int giftPassFloor { get; set; }

		public string difficulty { get; set; }

		public int id { get; set; }

		public string cameraId { get; set; }

		public string terrainId { get; set; }

		public string terrainColliderId { get; set; }

		public string stageCameraId { get; set; }

		public string heroSpawnLocation { get; set; }

		public int[] stageIds
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int[] gateIds { get; set; }

		public int[] stageActivatorIds { get; set; }

		public string nodeSpawner { get; set; }

		public string movementInfluenceId { get; set; }

		public int stageId { get; set; }

		public int nodeOrder { get; set; }

		public int mapId { get; set; }

		public int maxPotion { get; set; }

		public string rewardType { get; set; }

		public int reward1Star
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int reward2Star
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int reward3Star
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int levelRequire { get; set; }

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

		public ItemInfo GetReward()
		{
			return null;
		}

		public ItemInfo GetReward1Star()
		{
			return null;
		}

		public ItemInfo GetReward2Star()
		{
			return null;
		}

		public ItemInfo GetReward3Star()
		{
			return null;
		}
	}
}
