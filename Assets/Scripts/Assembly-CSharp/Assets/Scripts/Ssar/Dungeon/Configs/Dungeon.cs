using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.Configs
{
	public interface Dungeon
	{
		int Id();

		Vector3 HeroSpawnLocation();

		IEnumerable<Stage> StageList();

		IEnumerable<int> GateIdList();

		IEnumerable<int> StageActivatorList();
	}
}
