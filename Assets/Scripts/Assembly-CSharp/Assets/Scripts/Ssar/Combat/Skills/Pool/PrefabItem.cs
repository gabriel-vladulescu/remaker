using Assets.Scripts.Ssar.Common.Pooling;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Pool
{
	public class PrefabItem : Item
	{
		private string prefabPath;

		private GameObject prefab;

		public string PrefabPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameObject Prefab
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PrefabItem(string prefabPath)
		{
		}

		public PrefabItem(GameObject prefab)
		{
		}

		public PrefabItem(string prefabPath, GameObject prefab)
		{
		}

		public bool IsActive()
		{
			return false;
		}

		public void OnObtain()
		{
		}

		public void OnReturn()
		{
		}
	}
}
