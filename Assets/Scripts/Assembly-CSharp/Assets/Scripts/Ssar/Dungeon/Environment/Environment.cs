using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Environment.Character;
using Assets.Scripts.Ssar.Dungeon.Environment.Monster;
using Assets.Scripts.Ssar.Dungeon.Spawn;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.Environment
{
	public interface Environment
	{
		bool IsIdle();

		Assets.Scripts.Ssar.Dungeon.Environment.Character.Character Character();

		IEnumerable<Assets.Scripts.Ssar.Dungeon.Environment.Monster.Monster> DeadMonstersSoFar();

		IEnumerable<Assets.Scripts.Ssar.Dungeon.Environment.Monster.Monster> DeadMonstersSoFarIncludingOnesSpawnedByOthers();

		float ElapsedTime();

		GameObjectSpawner GameObjectSpawner();

		GameObject GetGateById(int gateId);

		bool AreAllBeatableMonstersFromCurrentStageDead();
	}
}
