using System;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public interface MonsterSpawner
	{
		void Spawn(string id, float x, float y, Action<GameObject, int> onSpawnSuccess);
	}
}
