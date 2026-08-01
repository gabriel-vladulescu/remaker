using System;
using System.Collections.Generic;
using Scripts.Ssar.Pet;
using Ssar.Craft.Model;
using Ssar.Rune.Model;

[Serializable]
public class ItemInfo
{
	public List<VisualId> equipmentVisualIdPrefer;

	private static readonly List<ItemType> ConfigIdTypes;

	public ItemType type { get; set; }

	public EquipmentConfigId EquipmentConfigId { get; set; }

	public PetConfigId PetConfigId { get; set; }

	public Rune Rune { get; set; }

	public CraftingMaterial Material { get; set; }

	public int quantity { get; set; }

	public int value { get; set; }

	public int petVisualIdPrefer { get; set; }

	public ItemInfo()
	{
	}

	public ItemInfo(ItemType type, int rewardValue, int quantity = 1)
	{
	}

	public ItemInfo(int randomEquipmentConfigId, int randomItemQuantity = 1)
	{
	}

	public ItemInfo(EquipmentConfigId equipmentConfig)
	{
	}

	public ItemInfo(Rune rune)
	{
	}

	public ItemInfo(PetConfigId pet)
	{
	}

	public ItemInfo(CraftingMaterial material)
	{
	}

	public ItemInfo SetValue(int value)
	{
		return null;
	}

	public ItemInfo RandomRune(int randomRuneConfigId, int quantity = 1)
	{
		return null;
	}

	public ItemInfo RandomPet(int randomPetconfigId, int quantity = 1)
	{
		return null;
	}

	public int GetTrueQuantity()
	{
		return 0;
	}
}
