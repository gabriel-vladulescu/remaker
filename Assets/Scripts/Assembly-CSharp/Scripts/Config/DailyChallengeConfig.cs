using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Model;
using Ssar.DailyChallenge.Model;

namespace Scripts.Config
{
	public class DailyChallengeConfig : IConfig
	{
		public class Constants
		{
			public bool enableResurrectionInDungeon { get; set; }

			public string highestDifficulty { get; set; }

			public int defaultStageId { get; set; }

			public int maxBuffOptions { get; set; }

			public int freeEntriesPerDay { get; set; }

			public ScenarioDifficulty GetHighestDifficulty()
			{
				return default(ScenarioDifficulty);
			}
		}

		public class Dungeon : IDungeonInfo
		{
			public int id { get; set; }

			public string cameraId { get; set; }

			public string terrainId { get; set; }

			public string terrainColliderId { get; set; }

			public string stageCameraId { get; set; }

			public string heroSpawnLocation { get; set; }

			public int[] stageIds { get; set; }

			public int[] gateIds { get; set; }

			public int[] stageActivatorIds { get; set; }

			public string nodeSpawner { get; set; }

			public string movementInfluenceId { get; set; }

			public string difficulty { get; set; }

			public int nodeOrder { get; set; }

			public int mapId { get; set; }

			public int maxPotion { get; set; }

			public int keyRequire { get; set; }

			public int powerSuggestion { get; set; }

			public ScenarioDifficulty GetDifficulty()
			{
				return default(ScenarioDifficulty);
			}

			public bool MayMimicAppear()
			{
				return false;
			}

			public float MimicAppearRate()
			{
				return 0f;
			}

			public string MimicId()
			{
				return null;
			}

			public void SetStageIds(int[] stageIds)
			{
			}
		}

		public class Sample
		{
			public int id { get; set; }

			public string spawner { get; set; }

			public int stageId { get; set; }
		}

		public class Round
		{
			public int id { get; set; }

			public bool enabled { get; set; }

			public int order { get; set; }

			public int[] samples { get; set; }

			public float atkScale { get; set; }

			public float defScale { get; set; }

			public float hpScale { get; set; }

			public float delayChangeRound { get; set; }

			public int[] buffIds { get; set; }

			public bool IsLevelUpRound()
			{
				return false;
			}
		}

		public class Buff
		{
			public int id { get; set; }

			public string type { get; set; }

			public double[] power { get; set; }

			public string nameLocalize { get; set; }

			public string descLocalize { get; set; }

			public string icon { get; set; }

			public BuffType GetBuffType()
			{
				return default(BuffType);
			}
		}

		public class Entry
		{
			public int entry { get; set; }

			public int cost { get; set; }
		}

		public class Pool
		{
			public int groupId { get; set; }

			public int id { get; set; }

			public int initCount { get; set; }
		}

		public Dictionary<string, Constants> constants;

		public Dictionary<string, Dungeon> dungeons;

		public Dictionary<string, Sample> samples;

		public Dictionary<string, Round> rounds;

		public Dictionary<string, Stage> stages;

		public Dictionary<string, Buff> buffs;

		public Dictionary<string, Entry> entries;

		public Dictionary<string, Pool> pools;

		public void OnMapValue(string content)
		{
		}

		public Constants GetConfigConstants()
		{
			return null;
		}

		public Dungeon GetDungeonByDifficulty(ScenarioDifficulty difficulty)
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

		public bool FindSampleById(int id, ref Sample sample)
		{
			return false;
		}

		public bool FindRoundById(int id, ref Round round)
		{
			return false;
		}

		public Round[] GetRounds()
		{
			return null;
		}

		public bool FindBuffById(int id, ref Buff buff)
		{
			return false;
		}

		public Entry GetEntry(int entryCount)
		{
			return null;
		}

		public int GetInitCount(int groupId, int id)
		{
			return 0;
		}

		private int CompareRound(Round a, Round b)
		{
			return 0;
		}

		private int CompareEntry(Entry a, Entry b)
		{
			return 0;
		}
	}
}
