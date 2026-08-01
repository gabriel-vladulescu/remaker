using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Environment;
using Assets.Scripts.Ssar.Dungeon.Environment.Character;
using Assets.Scripts.Ssar.Dungeon.Spawn;
using Checking;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.Stages.Challenges.Triggers
{
	public class WaitForDistanceTrigger : Trigger
	{
		private const float COOLDOWN = 0.1f;

		private float radius;

		private GameObjectSpawner gameObjectSpawner;

		private NotNullReference notNullReference;

		private Vector3 spawnerPos;

		private Character ch;

		private float cooldownCount;

		private bool isFinished;

		public WaitForDistanceTrigger()
		{
		}

		public WaitForDistanceTrigger(float radius)
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
	}
}
