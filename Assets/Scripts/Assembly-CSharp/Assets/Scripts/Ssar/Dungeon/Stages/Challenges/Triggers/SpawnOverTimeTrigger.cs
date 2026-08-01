using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Environment;
using Assets.Scripts.Ssar.Dungeon.Environment.Monster;
using Assets.Scripts.Ssar.Dungeon.Spawn;
using Checking;

namespace Assets.Scripts.Ssar.Dungeon.Stages.Challenges.Triggers
{
	public class SpawnOverTimeTrigger : Trigger
	{
		private string monsterId;

		private int monsterCount;

		private float spawnInterval;

		private int spawnCount;

		private float spawnX;

		private float spawnY;

		private GameObjectSpawner gameObjectSpawner;

		private float xAxisAmplitude;

		private int xAxisDensity;

		private int spawnCountSoFar;

		private float elapsedTimeSinceLastSpawn;

		private NotNullReference notNullReference;

		private int monsterCountSoFar;

		private Assets.Scripts.Ssar.Dungeon.Environment.Environment environment;

		private List<Monster> deadMonsters;

		private List<int> monsterSpawnIds;

		public SpawnOverTimeTrigger()
		{
		}

		public SpawnOverTimeTrigger(GameObjectSpawner gameObjectSpawner)
		{
		}

		public void SetEnv(Assets.Scripts.Ssar.Dungeon.Environment.Environment env)
		{
		}

		public void SetCookies(IEnumerable<string> cookies)
		{
		}

		public string UnfinishedReason()
		{
			return null;
		}

		public bool IsFinished()
		{
			return false;
		}

		public void Update(float dt, int waveOrder)
		{
		}

		public override string ToString()
		{
			return null;
		}

		private bool IsSpawnCompleted()
		{
			return false;
		}

		private float Random()
		{
			return 0f;
		}
	}
}
