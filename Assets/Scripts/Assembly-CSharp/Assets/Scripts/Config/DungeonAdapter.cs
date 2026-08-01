using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Configs;
using UnityEngine;

namespace Assets.Scripts.Config
{
	public class DungeonAdapter : Dungeon
	{
		private RawDungeon rawDungeon;

		private Vector3 heroSpawnLocation;

		public DungeonAdapter(RawDungeon rawDungeon, Vector3 heroSpawnLocation)
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
