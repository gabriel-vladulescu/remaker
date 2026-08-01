using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Command;
using Assets.Scripts.Ssar.Dungeon.Environment.Character;
using Assets.Scripts.Ssar.Dungeon.Environment.Monster;
using Assets.Scripts.Ssar.Dungeon.Spawn;
using Checking;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.Environment
{
	public class DefaultEnvironment : Environment
	{
		private Assets.Scripts.Ssar.Dungeon.Environment.Character.Character character;

		private GameObjectSpawner spawner;

		private List<Assets.Scripts.Ssar.Dungeon.Environment.Monster.Monster> deadMonstersSoFar;

		private List<Assets.Scripts.Ssar.Dungeon.Environment.Monster.Monster> deadMonstersSoFarIncludingOnesSpawnedByOthers;

		private float elapsedTime;

		private NotNullReference notNullReference;

		private List<GameObject> gates;

		private InitDungeonSystemCmd.SpawnedMonsterList spawnedMonsterList;

		private int currentStageOrder;

		private bool areAllBeatableMonstersFromCurrentStageDead;

		public DefaultEnvironment(Assets.Scripts.Ssar.Dungeon.Environment.Character.Character character, GameObjectSpawner spawner, List<GameObject> gates)
		{
		}

		public DefaultEnvironment(Assets.Scripts.Ssar.Dungeon.Environment.Character.Character character, GameObjectSpawner spawner)
		{
		}

		public bool IsIdle()
		{
			return false;
		}

		public Assets.Scripts.Ssar.Dungeon.Environment.Character.Character Character()
		{
			return null;
		}

		public IEnumerable<Assets.Scripts.Ssar.Dungeon.Environment.Monster.Monster> DeadMonstersSoFar()
		{
			return null;
		}

		public IEnumerable<Assets.Scripts.Ssar.Dungeon.Environment.Monster.Monster> DeadMonstersSoFarIncludingOnesSpawnedByOthers()
		{
			return null;
		}

		public GameObjectSpawner GameObjectSpawner()
		{
			return null;
		}

		public float ElapsedTime()
		{
			return 0f;
		}

		public GameObject GetGateById(int gateId)
		{
			return null;
		}

		public bool AreAllBeatableMonstersFromCurrentStageDead()
		{
			return false;
		}

		public void DisableDefaultLogicCheckMonsterDeath()
		{
		}

		public void ManualSetAllMonstersDead()
		{
		}

		public void Elapse(float dt)
		{
		}

		public void AddDeadMonster(Assets.Scripts.Ssar.Dungeon.Environment.Monster.Monster monster, bool isSpawnedByOthers = false)
		{
		}

		public void OnStageStart(int stageOrder)
		{
		}

		public void SetSpawnMonsterList(InitDungeonSystemCmd.SpawnedMonsterList sml)
		{
		}
	}
}
