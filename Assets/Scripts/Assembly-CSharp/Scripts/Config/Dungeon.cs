using Assets.Scripts.Ssar.Dungeon.Model;
using CodeStage.AntiCheat.ObscuredTypes;

namespace Scripts.Config
{
	public class Dungeon : IDungeonInfo
	{
		public int averageTime;

		public string[] mimic;

		public string bonusType;

		public string name;

		public string mode;

		private string mimicId;

		private float mimicAppearRate;

		private bool mimicMayAppear;

		private ObscuredInt mMaxExp;

		private ObscuredInt mMaxSoul;

		private ObscuredInt mStamina;

		public int nodeOrder { get; set; }

		public int mapId { get; set; }

		public int maxPotion { get; set; }

		public string difficulty { get; set; }

		public int maxExp
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int maxSoul
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

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

		public double statScale { get; set; }

		public void ParseMimicValue()
		{
		}

		public bool MayMimicAppear()
		{
			return false;
		}

		public string MimicId()
		{
			return null;
		}

		public float MimicAppearRate()
		{
			return 0f;
		}

		public NodeBonusRewardType GetNodeBonusRewardType()
		{
			return default(NodeBonusRewardType);
		}

		public ScenarioDifficulty GetDifficulty()
		{
			return default(ScenarioDifficulty);
		}

		public DungeonMode GetMode()
		{
			return default(DungeonMode);
		}
	}
}
