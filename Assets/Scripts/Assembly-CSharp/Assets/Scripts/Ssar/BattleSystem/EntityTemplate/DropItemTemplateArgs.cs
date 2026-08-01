using UnityEngine;

namespace Assets.Scripts.Ssar.BattleSystem.EntityTemplate
{
	public class DropItemTemplateArgs
	{
		public Vector3 position;

		public EquipmentConfigId configId;

		public GameObject prefab;

		public DropItemTemplateArgs(GameObject prefab, Vector3 position, EquipmentConfigId configId)
		{
		}
	}
}
