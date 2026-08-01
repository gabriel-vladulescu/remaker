using System.Collections.Generic;
using Assets.Scripts.Config;

namespace Assets.Scripts.Ssar.Dungeon.Configs
{
	public interface DungeonConfig
	{
		IEnumerable<Dungeon> DungeonsList();

		Dungeon GetDungeonById(int dungeonId);

		IEnumerable<Stage> StagesList();

		Stage GetStageById(int stageId);

		Gate GetGateById(int gateId);

		IEnumerable<Gate> GatesList();

		StageActivator GetStageActivatorById(int stageActivatorId);

		IEnumerable<StageActivator> StageActivatorsList();

		IEnumerable<MonsterId> FindMonsterIdsSpawnInDungeon(int dungeonId);
	}
}
