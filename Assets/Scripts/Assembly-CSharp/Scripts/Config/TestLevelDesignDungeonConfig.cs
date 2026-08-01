using System.Collections.Generic;

namespace Scripts.Config
{
	public class TestLevelDesignDungeonConfig : IConfig
	{
		public Dictionary<string, Dungeon> dungeons;

		public Dictionary<string, Stage> stages;

		public void OnMapValue(string content)
		{
		}

		public Dungeon GetDungeonById(int id)
		{
			return null;
		}

		public bool FindDungeonById(int id, ref Dungeon room)
		{
			return false;
		}

		public bool FindStageById(int id, ref Stage stage)
		{
			return false;
		}
	}
}
