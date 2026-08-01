using System;
using Assets.Scripts.Ssar.Common.System.Resources;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.Equipment
{
	public class CosmeticWeaponPrefabLoadingOperation
	{
		private EquipmentVisualConfig equipmentConfig;

		private ResourcesLoader resourcesLoader;

		public CosmeticWeaponPrefabLoadingOperation(EquipmentVisualConfig equipmentConfig, ResourcesLoader resourcesLoader)
		{
		}

		public void Act(Action<bool, GameObject, string> onLoadCompleted, int groupId, int subId, CharacterVisualInfo cosmeticWeapon)
		{
		}
	}
}
