using System.Collections.Generic;
using System.Linq;
using LitJson;

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
			JsonData root = JsonMapper.ToObject(content);
			dungeons = ReadDictionary<Dungeon>(root, "dungeons");
			stages = ReadDictionary<Stage>(root, "stages");
			map = ReadDictionary<MapInfo>(root, "map");
			mimics = ReadDictionary<MimicConfig>(root, "mimics");
			difficulty = ReadDictionary<ScenarioDifficultyInfo>(root, "difficulty");
			constants = ReadDictionary<DungeonConfigConstant>(root, "constants");
			dungeonTutorial = ReadDictionary<Dungeon>(root, "dungeonTutorial");

			foreach (Dungeon d in dungeons.Values)
			{
				d.ParseMimicValue();
			}
			foreach (Dungeon d in dungeonTutorial.Values)
			{
				d.ParseMimicValue();
				tutorial = d;
			}

			tableMap = new Dictionary<string, List<Dungeon>>();
			foreach (Dungeon d in dungeons.Values)
			{
				string key = d.mapId + "_" + d.difficulty;
				if (!tableMap.TryGetValue(key, out List<Dungeon> list))
				{
					list = new List<Dungeon>();
					tableMap[key] = list;
				}
				list.Add(d);
			}
			foreach (List<Dungeon> list in tableMap.Values)
			{
				list.Sort(ComparerDungeonId);
			}
		}

		private static Dictionary<string, T> ReadDictionary<T>(JsonData root, string key)
		{
			if (root == null || !root.Keys.Contains(key))
			{
				return new Dictionary<string, T>();
			}
			return JsonMapper.ToObject<Dictionary<string, T>>(root[key].ToJson());
		}

		public MapInfo GetFirstMap()
		{
			return map.Values.OrderBy((MapInfo m) => m.id).FirstOrDefault();
		}

		public MapInfo GetHighestMap()
		{
			return map.Values.OrderByDescending((MapInfo m) => m.id).FirstOrDefault();
		}

		public MapInfo GetMapInfo(int mapId)
		{
			return map.Values.FirstOrDefault((MapInfo m) => m.id == mapId);
		}

		public List<Dungeon> GetListDungeons(int mapId, ScenarioDifficulty difficulty)
		{
			string key = mapId + "_" + difficulty;
			if (tableMap != null && tableMap.TryGetValue(key, out List<Dungeon> list))
			{
				return list;
			}
			return new List<Dungeon>();
		}

		public Dungeon GetDungeonInfo(int id)
		{
			return dungeons.Values.FirstOrDefault((Dungeon d) => d.id == id);
		}

		public Dungeon GetDungeonInfo(int mapId, int nodeOrder, ScenarioDifficulty difficulty)
		{
			return GetListDungeons(mapId, difficulty).FirstOrDefault((Dungeon d) => d.nodeOrder == nodeOrder);
		}

		public Stage GetStageInfo(int stageId)
		{
			return stages.Values.FirstOrDefault((Stage s) => s.id == stageId);
		}

		public int GetMapIdOf(int dungeonId)
		{
			Dungeon d = GetDungeonInfo(dungeonId);
			return (d != null) ? d.mapId : 0;
		}

		public int GetDungeonIdOfLastDungeonOfMap(int mapId)
		{
			return GetDungeonIdOfLastDungeonOfMap(mapId, ScenarioDifficulty.NORMAL);
		}

		public int GetDungeonIdOfLastDungeonOfMap(int mapId, ScenarioDifficulty difficulty)
		{
			List<Dungeon> list = GetListDungeons(mapId, difficulty);
			return (list.Count > 0) ? list[list.Count - 1].id : 0;
		}

		public int GetDungeonIdOfFirstDungeonOfMap(int mapId, ScenarioDifficulty difficulty)
		{
			List<Dungeon> list = GetListDungeons(mapId, difficulty);
			return (list.Count > 0) ? list[0].id : 0;
		}

		public ScenarioDifficultyInfo GetDifficultyInfo(ScenarioDifficulty dif)
		{
			return difficulty.Values.FirstOrDefault((ScenarioDifficultyInfo d) => d.GetDifficulty() == dif);
		}

		public Dungeon GetTutorialDungeon()
		{
			return tutorial;
		}

		public DungeonConfigConstant GetDungeonConfigConstant()
		{
			return constants.Values.FirstOrDefault();
		}

		private int ComparerDungeonId(Dungeon a, Dungeon b)
		{
			return a.nodeOrder.CompareTo(b.nodeOrder);
		}
	}
}
