using System.Collections.Generic;
using Assets.Scripts.Config;
using Assets.Scripts.Ssar.Dungeon.Configs;
using UnityEngine;

public class FactoryTestLogic : MonoBehaviour
{
	private class TestDungeonConfig : DungeonConfig
	{
		private List<Dungeon> dungeonsList;

		private List<Stage> stagesList;

		private List<Goal> goals;

		private List<LosingCondition> losingConditions;

		private List<Challenge> challenges;

		private List<Trigger> triggers;

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

		public IEnumerable<Goal> GoalsList()
		{
			return null;
		}

		public IEnumerable<LosingCondition> LosingConditionsList()
		{
			return null;
		}

		public IEnumerable<Challenge> ChallengesList()
		{
			return null;
		}

		public IEnumerable<Trigger> TriggersList()
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
	}

	private class TestDungeon : Dungeon
	{
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

	private class TestStage : Stage
	{
		public int Id()
		{
			return 0;
		}

		public IEnumerable<Goal> GoalList()
		{
			return null;
		}

		public IEnumerable<LosingCondition> LosingConditionList()
		{
			return null;
		}

		public IEnumerable<Challenge> ChallengeList()
		{
			return null;
		}

		public int WaveCount()
		{
			return 0;
		}
	}

	private class TestGoal : Goal
	{
		private int id;

		private string className;

		private IEnumerable<string> cookies;

		public TestGoal(int id, string className, IEnumerable<string> cookies)
		{
		}

		public int Id()
		{
			return 0;
		}

		public string ClassName()
		{
			return null;
		}

		public IEnumerable<string> CookiesList()
		{
			return null;
		}
	}

	private class TestLosingCondition : LosingCondition
	{
		private int id;

		private string className;

		private IEnumerable<string> cookies;

		public TestLosingCondition(int id, string className, IEnumerable<string> cookies)
		{
		}

		public int Id()
		{
			return 0;
		}

		public string Name()
		{
			return null;
		}

		public string ClassName()
		{
			return null;
		}

		public IEnumerable<string> CookiesList()
		{
			return null;
		}
	}

	private class TestChallenge : Challenge
	{
		private int id;

		private int startTriggerId;

		private int mainTriggerId;

		public TestChallenge(int id, int startTriggerId, int mainTriggerId)
		{
		}

		public int WaveOrder()
		{
			return 0;
		}

		public Trigger StartTrigger()
		{
			return null;
		}

		public Trigger MainTrigger()
		{
			return null;
		}
	}

	private class TestTrigger : Trigger
	{
		private int id;

		private string className;

		private IEnumerable<string> cookies;

		public TestTrigger(int id, string className, IEnumerable<string> cookies)
		{
		}

		public int Id()
		{
			return 0;
		}

		public string ClassName()
		{
			return null;
		}

		public IEnumerable<string> CookiesList()
		{
			return null;
		}
	}

	private DungeonConfigAdapter dungeonConfigAdapter;

	private void Start()
	{
	}

	private void CreateFromTestConfig()
	{
	}

	private void CreateFromTextConfig()
	{
	}

	private void OnCreateAdapterComplete()
	{
	}

	private void Update()
	{
	}
}
