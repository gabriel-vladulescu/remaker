using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar.Combat.Skills;
using UnityEngine;

namespace Core.Skills.Spawners
{
	public class Spawner
	{
		private Skill skill;

		private Environment environment;

		private MonsterSpawner monsterSpawner;

		private EventFrame eventFrame;

		private float elapsed;

		private List<float> pendingFrames;

		public Spawner(Skill skill, Environment environment, MonsterSpawner monsterSpawner, EventFrame eventFrame)
		{
		}

		public void Update(float dt)
		{
		}

		public void Interrupt()
		{
		}

		private void InitData()
		{
		}

		private void Spawn()
		{
		}

		private Vector4 GetSpawnPosition()
		{
			return default(Vector4);
		}

		private void JumpToDestination(SpawnMonster config, GameObject o, float destinationX, float spawnX)
		{
		}
	}
}
