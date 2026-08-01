using System.Collections.Generic;

namespace Scripts.Config
{
	public class DungeonConfig : IConfig
	{
		public Dictionary<string, DungeonConfigConstant> constants;

		public Dictionary<string, Dungeon> dungeons;

		public Dictionary<string, Stage> stages;

		public Dictionary<string, MapInfo> map;

		public Dictionary<string, MimicConfig> mimics;

		public Dictionary<string, ScenarioDifficultyInfo> difficulty;

		public Dictionary<string, Dungeon> dungeonTutorial;

		private Dictionary<string, List<Dungeon>> tableMap;

		private Dungeon tutorial;

		public void OnMapValue(string content)
		{
		}

		public MapInfo GetFirstMap()
		{
			return null;
		}

		public MapInfo GetHighestMap()
		{
			return null;
		}

		public MapInfo GetMapInfo(int mapId)
		{
			return null;
		}

		public List<Dungeon> GetListDungeons(int mapId, ScenarioDifficulty difficulty)
		{
			return null;
		}

		public Dungeon GetDungeonInfo(int id)
		{
			return null;
		}

		public Dungeon GetDungeonInfo(int mapId, int nodeOrder, ScenarioDifficulty difficulty)
		{
			return null;
		}

		public Stage GetStageInfo(int stageId)
		{
			return null;
		}

		public int GetMapIdOf(int dungeonId)
		{
			return 0;
		}

		public int GetDungeonIdOfLastDungeonOfMap(int mapId)
		{
			return 0;
		}

		public int GetDungeonIdOfLastDungeonOfMap(int mapId, ScenarioDifficulty difficulty)
		{
			return 0;
		}

		public int GetDungeonIdOfFirstDungeonOfMap(int mapId, ScenarioDifficulty difficulty)
		{
			return 0;
		}

		public ScenarioDifficultyInfo GetDifficultyInfo(ScenarioDifficulty dif)
		{
			return null;
		}

		public Dungeon GetTutorialDungeon()
		{
			return null;
		}

		public DungeonConfigConstant GetDungeonConfigConstant()
		{
			return null;
		}

		private int ComparerDungeonId(Dungeon a, Dungeon b)
		{
			return 0;
		}
	}
}
