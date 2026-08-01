using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Configs;
using UnityEngine;

namespace Assets.Scripts.Config
{
	public class MixDungeonAdapter : Dungeon
	{
		private RawDungeon rawDungeon;

		private DungeonConfigInspector dungeonConfigInspector;

		private List<Stage> stages;

		public MixDungeonAdapter(RawDungeon rawDungeon, DungeonConfigInspector dungeonConfigInspector, List<Stage> stages)
		{
		}

		public int Id()
		{
			return 0;
		}

		public Vector3 HeroSpawnLocation()
		{
			return default(Vector3);
		}

		public IEnumerable<Stage> StageList()
		{
			return null;
		}

		public IEnumerable<int> GateIdList()
		{
			return null;
		}

		public IEnumerable<int> StageActivatorList()
		{
			return null;
		}
	}
}
