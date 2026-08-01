namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public interface IDungeonInfo
	{
		int id { get; set; }

		string cameraId { get; set; }

		string terrainId { get; set; }

		string terrainColliderId { get; set; }

		string stageCameraId { get; set; }

		string heroSpawnLocation { get; set; }

		int[] stageIds { get; set; }

		int[] gateIds { get; set; }

		int[] stageActivatorIds { get; set; }

		string nodeSpawner { get; set; }

		string movementInfluenceId { get; set; }

		string difficulty { get; set; }

		int nodeOrder { get; set; }

		int mapId { get; set; }

		int maxPotion { get; set; }

		ScenarioDifficulty GetDifficulty();

		bool MayMimicAppear();

		float MimicAppearRate();

		string MimicId();
	}
}
