using Assets.Scripts.Ssar.Dungeon;
using Assets.Scripts.Ssar.Dungeon.Environment;
using Assets.Scripts.Ssar.Dungeon.Environment.Monster;
using UnityEngine;

public class DungeonWithStagesTestLogic : MonoBehaviour
{
	private class TestMonster : Monster
	{
		private float deadTime;

		private MonsterType monsterType;

		public TestMonster(MonsterType monsterType, float deadTime)
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

	private Dungeon dungeon;

	private DungeonResult dungeonResult;

	private DefaultEnvironment defaultEnvironment;

	private GameObject characterGameObject;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void HandleInput()
	{
	}

	private void ReviveHero()
	{
	}

	private void KillHero()
	{
	}

	private TestMonster KillAMonster(MonsterType monsterType)
	{
		return null;
	}
}
