using Assets.Scripts.Ssar.Dungeon.Model;

namespace Scripts.Config
{
	public class ArenaDungeonInfo : IDungeonInfo
	{
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
}
