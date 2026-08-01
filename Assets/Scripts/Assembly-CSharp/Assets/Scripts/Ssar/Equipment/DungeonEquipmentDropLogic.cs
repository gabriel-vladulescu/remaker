using System.Collections.Generic;
using Assets.Scripts.Config;
using Assets.Scripts.Ssar.Dungeon;
using Scripts.Config;
using Ssar.Analytics.Metrics;

namespace Assets.Scripts.Ssar.Equipment
{
	public class DungeonEquipmentDropLogic
	{
		private DungeonEquipmentDropConfig dungeonEquipmentDropConfig;

		private EquipmentDropLogic equipmentDropLogic;

		private EquipmentVisualConfig equipmentConfig;

		private Dictionary<int, int> dropCountByDungeonId;

		private DungeonConfig dungeonConfig;

		private Assets.Scripts.Ssar.Dungeon.Dungeon dungeon;

		private int stageOrder;

		public DungeonEquipmentDropLogic(DungeonEquipmentDropConfig dungeonEquipmentDropConfig, EquipmentDropLogic equipmentDropLogic, EquipmentVisualConfig equipmentConfig, DungeonConfig dungeonConfig, Assets.Scripts.Ssar.Dungeon.Dungeon dungeon)
		{
		}

		public bool Drop(CharacterId characterId, int fromDungeonId, MonsterId monsterId, ref EquipmentConfigId droppedEquipmentConfigId, float dropRateBonus)
		{
			return false;
		}
	}
}
