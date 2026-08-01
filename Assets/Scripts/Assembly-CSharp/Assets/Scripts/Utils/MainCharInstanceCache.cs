using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Utils
{
	public class MainCharInstanceCache : MonoBehaviour
	{
		public static MainCharInstanceCache instance;

		private Dictionary<string, GameObject> cache;

		private void Awake()
		{
		}

		public void Add(string resoucesPath, GameObject prefab)
		{
		}
	}
}
