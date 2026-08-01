using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Command;

namespace Scripts.Ssar.Arena
{
	public class ArenaReplayData
	{
		public Dictionary<string, List<InputData>> inputs;

		public MainCharacterData mainCharacterData;

		public MainCharacterData opponentData;

		public ArenaResultData arenaResultData;

		public SelectArenaRuneParameter SelectArenaRuneParameter;

		public int randomSeed;

		public ArenaReplayData()
		{
		}

		public ArenaReplayData(int randomSeed, MainCharacterData mainCharacterData, MainCharacterData opponentData, Dictionary<string, List<InputData>> inputs, ArenaResultData arenaResultData, SelectArenaRuneParameter runeParameter)
		{
		}
	}
}
