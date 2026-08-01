using System.Collections.Generic;
using Artemis;
using Artemis.System;
using Assets.Scripts.Ssar.Equipment;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.System
{
	public class DungeonItemDropSystem : EntitySystemWithTime
	{
		private class DropData
		{
			public Entity Entity;

			public EquipmentConfigId EquipmentConfigId;

			private CharacterMediatorComponent characterMediator;

			public int stage;

			public DropData(Entity entity, EquipmentConfigId configId, int stage)
			{
			}

			public bool IsTrigger()
			{
				return false;
			}
		}

		private class DropItemNotify
		{
			public void ObtainEquipment(ItemInfo itemInfo)
			{
			}
		}

		private DungeonEquipmentDropLogic dungeonEquipmentDropLogic;

		private float dropRateBonus;

		private List<DropData> listDropDatas;

		private DropItemNotify notify;

		public DungeonItemDropSystem(DungeonEquipmentDropLogic dungeonEquipmentDropLogic, float dropRateBonus)
		{
		}

		private void DamageCalculationSystemOnEntityDeathEvent(Entity entity)
		{
		}

		protected override void Process(float deltaTime)
		{
		}

		public void AutoPickAllEquipmentOfCurrentStage()
		{
		}

		private void Remove(DropData dropData)
		{
		}

		private void PickItem(DropData dropData)
		{
		}

		private void DropItem(Entity entity)
		{
		}

		private bool IsTutorial()
		{
			return false;
		}

		private void DropSoul(Entity entity)
		{
		}

		private void DropEquipment(Entity entity)
		{
		}

		private UISfx GetUISFX(EquipmentCategory equipmentCategory)
		{
			return default(UISfx);
		}

		private void GenerateIcon(EquipmentConfigId configId, GameObject prefab)
		{
		}
	}
}
