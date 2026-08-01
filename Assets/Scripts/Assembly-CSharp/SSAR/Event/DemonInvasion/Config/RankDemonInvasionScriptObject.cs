using System;
using System.Collections.Generic;
using UnityEngine;

namespace Ssar.Event.DemonInvasion.Config
{
	[Serializable]
	[CreateAssetMenu(menuName = "ScriptableOject/RankDemonInvasion")]
	public class RankDemonInvasionScriptObject : ScriptableObject
	{
		[Serializable]
		public class RankDemon
		{
			public float timeBattle;

			public string nameRank;
		}

		public List<RankDemon> rankDemons;
	}
}
