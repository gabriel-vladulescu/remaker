using System.Collections.Generic;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using SSAR.Equipment.View;

public class GetAllEquipmentCanSellRule : IGetCollectDataRule
{
	private List<EquipmentCombinedType> categories;

	private List<Rarity> rarities;

	private ItemLockData lockData;

	private MainCharacterData mainCharacterData;

	public GetAllEquipmentCanSellRule(List<EquipmentCombinedType> categories, List<Rarity> rarities)
	{
	}

	public bool IsSuitableConditions(ICollectData collectData)
	{
		return false;
	}
}
