using System;
using System.Collections.Generic;
using Assets.Scripts.Model;
using SSAR.Equipment.Model;
using Scripts.Ssar.Pet;

namespace Assets.Scripts.Ssar.Equipment.Command
{
	public class ShowEquipmentPreviewParameter
	{
		public IItem item;

		public Action onClickOk;

		public Action onClickClose;

		public MainCharacterData MainCharacterData;

		public IItem targetCompare;

		public ShowEquipmentPreviewParameter(EquipmentConfigId equipmentConfigId, int enhanceLv, int awakenExp, Action onClickOk, Action onClickClose, MainCharacterData mainCharacterData = null)
		{
		}

		public ShowEquipmentPreviewParameter(IItem item, Action onClickOk, Action onClickClose, MainCharacterData mainCharacterData = null)
		{
		}

		public ShowEquipmentPreviewParameter(PetConfigId equipmentConfigId, int enhanceLv, int awakenExp, Action onClickOk, Action onClickClose, MainCharacterData mainCharacterData = null)
		{
		}

		public ShowEquipmentPreviewParameter(PetCollectData petCollectData, Action onClickOk, Action onClickClose, MainCharacterData mainCharacterData)
		{
		}

		public ShowEquipmentPreviewParameter SetRune(List<RuneSlot> runeSlots)
		{
			return null;
		}

		public ShowEquipmentPreviewParameter SetReforgeCount(int count)
		{
			return null;
		}

		public ShowEquipmentPreviewParameter SetOwnerName(string name)
		{
			return null;
		}

		public ShowEquipmentPreviewParameter SetCompareWith(IItem targetItem)
		{
			return null;
		}
	}
}
