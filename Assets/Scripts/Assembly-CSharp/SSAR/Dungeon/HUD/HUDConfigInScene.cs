using UnityEngine;

namespace SSAR.Dungeon.HUD
{
	public class HUDConfigInScene
	{
		public Transform HUDRoot { get; set; }

		public GameObject HUDParentPrefab { get; set; }

		public GameObject SpawnDamagePrefab { get; set; }

		public GameObject SpawnEffectPrefab { get; set; }

		public GameObject SmallHpBarPrefab { get; set; }

		public GameObject MediumHpBarPrefab { get; set; }

		public GameObject NotifyObtainEquipmentPrefab { get; set; }

		public GameObject CharacterNamePrefab { get; set; }

		public void Init(GameObject root)
		{
		}
	}
}
