using System.Collections.Generic;
using LitJson;

namespace Scripts.Config
{
	public class BloodyTowerConfig : IConfig
	{
		public class Entry
		{
			public int entry { get; set; }

			public int cost { get; set; }
		}

		public Dictionary<string, BloodyTowerConfigConstant> constants;

		public Dictionary<string, Entry> entries;

		public Dictionary<string, BloodyTowerFloorInfo> floors;

		public Dictionary<string, HeroLevelStats> monsterFloor1;

		public Dictionary<string, Stage> stages;

		private Dictionary<int, Dictionary<string, HeroLevelStats>> monsterStats;

		private List<string> dicBehaviour;

		private List<string> categories;

		public void OnMapValue(string content)
		{
		}

		public HeroLevelStats FindHeroBasicStats(int groupId, int id, int level, int floor)
		{
			return null;
		}

		private Dictionary<string, HeroLevelStats> GetDictHeroStats(int floor)
		{
			return null;
		}

		public BloodyTowerFloorInfo GetBloodyTowerFloorInfo(int floor)
		{
			return null;
		}

		public bool FindFloorById(int id, ref BloodyTowerFloorInfo btfi)
		{
			return false;
		}

		public bool FindStageById(int id, ref Stage s)
		{
			return false;
		}

		private void Setup(string content)
		{
		}

		private T MapData<T>(JsonData data) where T : class
		{
			return null;
		}

		private string GetCategoryFromAITag(string aitag)
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

		public BloodyTowerConfigConstant GetConfigConstant()
		{
			return null;
		}

		public Entry GetEntry(int entryCount)
		{
			return null;
		}
	}
}
