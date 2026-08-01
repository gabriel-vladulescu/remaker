using System;
using UnityEngine;

namespace Assets.Scripts.Config
{
	[Serializable]
	public class TriggerInspector
	{
		public TriggerName triggerName;

		public float waitTime;

		public float waitTimeAmplitude;

		public int waitTimeDensity;

		public string monsterId;

		public int monsterCount;

		public GameObject spawnLocation;

		public float xAxisAmplitude;

		public int xAxisDensity;

		public float spawnInterval;

		public int spawnCount;

		public float radius;
	}
}
