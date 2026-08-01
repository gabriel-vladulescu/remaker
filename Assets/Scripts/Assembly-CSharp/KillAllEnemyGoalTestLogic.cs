using Assets.Scripts.Ssar.Dungeon.Environment;
using Assets.Scripts.Ssar.Dungeon.Environment.Monster;
using Assets.Scripts.Ssar.Dungeon.Stages;
using Assets.Scripts.Ssar.Dungeon.Stages.Goals;
using UnityEngine;

public class KillAllEnemyGoalTestLogic : MonoBehaviour
{
	private class TestMonster : Monster
	{
		private float deadTime;

		public TestMonster(float deadTime)
		{
		}

		public float DeadTime()
		{
			return 0f;
		}

		public MonsterType Type()
		{
			return default(MonsterType);
		}

		public string ConfigId()
		{
			return null;
		}

		public int SpawnId()
		{
			return 0;
		}
	}

	private DefaultStage stage;

	private KillAllEnemyGoal killAllEnemyGoal;

	private DefaultEnvironment defaultEnvironment;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void HandleInput()
	{
	}
}
