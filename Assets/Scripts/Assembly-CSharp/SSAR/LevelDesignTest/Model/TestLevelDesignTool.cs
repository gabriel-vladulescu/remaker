using System;
using UnityEngine;

namespace Ssar.LevelDesignTest.Model
{
	[Serializable]
	[CreateAssetMenu(menuName = "ScriptableOject/TestLevelDesignTool")]
	public class TestLevelDesignTool : ScriptableObject
	{
		[HideInInspector]
		public string mainCharacterData;

		public string terrainId;

		public string terrainCollideId;

		public string stageCamera;

		public string nodeSpawner;

		public string stageIds;

		public string difficulty;

		public int[] GetStageIds()
		{
			return null;
		}
	}
}
