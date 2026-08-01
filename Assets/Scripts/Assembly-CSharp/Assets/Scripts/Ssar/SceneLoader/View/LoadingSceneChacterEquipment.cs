using System;
using SSAR.Equipment.Enum;

namespace Assets.Scripts.Ssar.SceneLoader.View
{
	[Serializable]
	public class LoadingSceneChacterEquipment
	{
		public EquipmentType EquipmentType;

		public int visualId;

		public LoadingSceneChacterEquipment(EquipmentType equipmentType, int visualid)
		{
		}
	}
}
