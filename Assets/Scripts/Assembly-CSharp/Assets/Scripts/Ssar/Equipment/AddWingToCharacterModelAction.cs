using System;
using Assets.Scripts.Ssar.Common.System.Resources;
using SSAR.Equipment.Enum;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.Equipment
{
	public class AddWingToCharacterModelAction
	{
		private EquipmentVisualConfig equipmentConfig;

		private ResourcesLoader resourcesLoader;

		public AddWingToCharacterModelAction(EquipmentVisualConfig equipmentConfig, ResourcesLoader resourcesLoader)
		{
		}

		public void Act(GameObject model, int groupId, int subId, int visualId, Rarity rarity, Action<GameObject> cb, bool inBattle = false)
		{
		}

		private string GetJointName(int groupId)
		{
			return null;
		}
	}
}
