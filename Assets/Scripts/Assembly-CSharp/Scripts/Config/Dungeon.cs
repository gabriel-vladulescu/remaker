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
				return mMaxExp;
			}
			set
			{
				mMaxExp = value;
			}
		}

		public int maxSoul
		{
			get
			{
				return mMaxSoul;
			}
			set
			{
				mMaxSoul = value;
			}
		}

		public int staminaRequire
		{
			get
			{
				return mStamina;
			}
			set
			{
				mStamina = value;
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
			mimicMayAppear = mimic != null && mimic.Length > 0;
			if (mimicMayAppear)
			{
				mimicId = mimic[0];
				mimicAppearRate = mimic.Length > 1 && float.TryParse(mimic[1], out var rate) ? rate : 0f;
			}
		}

		public bool MayMimicAppear()
		{
			return mimicMayAppear;
		}

		public string MimicId()
		{
			return mimicId;
		}

		public float MimicAppearRate()
		{
			return mimicAppearRate;
		}

		public NodeBonusRewardType GetNodeBonusRewardType()
		{
			if (string.IsNullOrEmpty(bonusType) || !System.Enum.TryParse<NodeBonusRewardType>(bonusType, out var result))
			{
				return NodeBonusRewardType.None;
			}
			return result;
		}

		public ScenarioDifficulty GetDifficulty()
		{
			if (string.IsNullOrEmpty(difficulty) || !System.Enum.TryParse<ScenarioDifficulty>(difficulty, out var result))
			{
				return ScenarioDifficulty.NORMAL;
			}
			return result;
		}

		public DungeonMode GetMode()
		{
			if (string.IsNullOrEmpty(mode) || !System.Enum.TryParse<DungeonMode>(mode, out var result))
			{
				return DungeonMode.SCENARIO;
			}
			return result;
		}
	}
}
