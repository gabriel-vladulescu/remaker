using System;
using UnityEngine;

namespace Ssar.DailyChallenge.Test
{
	[Serializable]
	[CreateAssetMenu(menuName = "ScriptableOject/TestDailyChallengeData")]
	public class TestDailyChallengeData : ScriptableObject
	{
		[HideInInspector]
		public string mainCharacterData;

		public int[] roundIds;

		public string difficulty;

		public int randomSeed;
	}
}
