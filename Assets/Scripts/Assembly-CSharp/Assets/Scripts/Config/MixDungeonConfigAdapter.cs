using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Configs;
using Checking;

namespace Assets.Scripts.Config
{
	public class MixDungeonConfigAdapter : DungeonConfig
	{
		protected RawDungeonConfig rawDungeonConfig;

		protected DungeonConfigInspector dungeonConfigInspector;

		private NotNullReference notNullReference;

		private Dictionary<string, Dungeon> dungeons;

		private Dictionary<string, Stage> stages;

		private Dictionary<string, Gate> gates;

		private Dictionary<string, StageActivator> stageActivators;

		public MixDungeonConfigAdapter(RawDungeonConfig rawDungeonConfig, DungeonConfigInspector dungeonConfigInspector)
		{
		}

		public IEnumerable<Dungeon> DungeonsList()
		{
			return null;
		}

		public Dungeon GetDungeonById(int dungeonId)
		{
			return null;
		}

		public IEnumerable<Stage> StagesList()
		{
			return null;
		}

		public Stage GetStageById(int stageId)
		{
			return null;
		}

		public Gate GetGateById(int gateId)
		{
			return null;
		}

		public IEnumerable<Gate> GatesList()
		{
			return null;
		}

		public StageActivator GetStageActivatorById(int stageActivatorId)
		{
			return null;
		}

		public IEnumerable<StageActivator> StageActivatorsList()
		{
			return null;
		}

		public IEnumerable<MonsterId> FindMonsterIdsSpawnInDungeon(int dungeonId)
		{
			return null;
		}

		protected virtual int[] GetStageIds(RawDungeon rawDungeon)
		{
			return null;
		}

		private List<Stage> BuildStageList(int[] stageIds)
		{
			return null;
		}

		private void BuildGates()
		{
		}

		private void BuildStageActivators()
		{
		}
	}
}
