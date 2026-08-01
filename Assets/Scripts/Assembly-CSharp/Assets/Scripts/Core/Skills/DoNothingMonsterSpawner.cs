using System;
using Assets.Scripts.Ssar.Combat.Skills;
using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	internal class DoNothingMonsterSpawner : MonsterSpawner
	{
		public void Spawn(string id, float x, float y, Action<GameObject, int> onSpawnSuccess)
		{
		}
	}
}
