using System;
using System.Collections.Generic;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using SSAR.Equipment.View;
using Scripts.Ssar.Pet;
using Ssar.Craft.Enum;
using Ssar.Craft.Model;
using Ssar.Rune.Model;

[Serializable]
public class InventoryData
{
	public Dictionary<string, EquipmentCollectData> equipmentCollectDatas;

	public Dictionary<string, BoostItemCollectData> boostItemCollectDatas;

	public Dictionary<string, MemoryShardCollectData> memoryShardCollectDatas;

	public Dictionary<string, PetCollectData> petCollectDatas;

	public List<Rune> runes;

	public List<CraftingMaterial> materials;

	public int expandLevel;

	public int GetInventoryExpandLevel()
	{
		return 0;
	}

	public void IncreaseInventoryExpandLevel(int value)
	{
	}

	public void SetExpandLevel(int expandLevel)
	{
	}

	public void ReplaceRuneSlotOfEquipment(EquipmentCollectData ecd, int slotIndex, RuneType runeType, RuneRarity runeRarity, ref Rune runeToReturn, ref Rune runeToTake)
	{
	}

	public void EquipRuneSlotOfEquipment(EquipmentCollectData ecd, int slotIndex, RuneType runeType, RuneRarity runeRarity, ref Rune refRune)
	{
	}

	private void CheckIfRuneIsSufficient(EquipmentCollectData ecd, int slotIndex, RuneType runeType, RuneRarity runeRarity)
	{
	}

	public void UnequipRuneSlotOfEquipment(EquipmentCollectData ecd, int slotIndex, ref Rune refRune)
	{
	}

	private void CheckIfRunesHaveEnoughStorage(EquipmentCollectData equipmentCollectData, int slotIndex)
	{
	}

	public void UnequipRuneSlotsOfEquipment(EquipmentCollectData equipmentCollectData)
	{
	}

	private void CheckIfRunesHaveEnoughStorage(EquipmentCollectData equipmentCollectData)
	{
	}

	public bool AddRune(RuneType type, RuneRarity runeRarity, int number, RewardReason reason)
	{
		return false;
	}

	public bool AddRune(RuneType type, RuneRarity runeRarity, int number, ref Rune rune, RewardReason rewardReason)
	{
		return false;
	}

	public bool RemoveRune(RuneType type, RuneRarity runeRarity, int number, ConsumeRuneReason reason)
	{
		return false;
	}

	public bool RemoveRune(RuneType type, RuneRarity runeRarity, int number, ref Rune rune, ConsumeRuneReason reason)
	{
		return false;
	}

	public bool FindRune(RuneType type, RuneRarity runeRarity, ref Rune rune)
	{
		return false;
	}

	public int GetRuneCount(RuneType type, RuneRarity runeRarity)
	{
		return 0;
	}

	public List<ICollectData> GetRuneList(IGetCollectDataRule rule = null, CollectDataComparer comparer = null)
	{
		return null;
	}

	private int FindAvailableCollectIdForRune()
	{
		return 0;
	}

	public List<Rune> GetAllRunes()
	{
		return null;
	}

	public EquipmentCollectData AddNewEquipment(EquipmentConfigId configId)
	{
		return null;
	}

	public int TotalEquipmentCount()
	{
		return 0;
	}

	public EquipmentCollectData GetEquipmentCollectData(int equipmentCollectId)
	{
		return null;
	}

	public List<EquipmentCollectData> GetAllEquipmentCollectDatas()
	{
		return null;
	}

	public List<ICollectData> EquipmentList(IGetCollectDataRule rule = null, CollectDataComparer comparer = null)
	{
		return null;
	}

	public void RemoveEquipment(EquipmentCollectData equipmentCollectData)
	{
	}

	public void ReplaceEquipment(int collectID, EquipmentCollectData equipmentCollectData)
	{
	}

	private EquipmentCollectData AddEquipmentToCollect(EquipmentConfigId configId, int collectID)
	{
		return null;
	}

	private List<ICollectData> ToList(CollectType type, CollectDataComparer comparer, IGetCollectDataRule rule)
	{
		return null;
	}

	public BoostItemCollectData GetBoostItemCollectData(BoostItemType type)
	{
		return null;
	}

	public int GetQuantityOfBoostItem(BoostItemType type)
	{
		return 0;
	}

	public void AddQuantityOfBoostItem(BoostItemType type, int quantity)
	{
	}

	public void ConsumeBoostItem(BoostItemType type)
	{
	}

	public MemoryShardCollectData AddMemoryShard(int mirrorId, int shardId)
	{
		return null;
	}

	public bool HasCollectedShard(int mirrorId, int shardId)
	{
		return false;
	}

	public List<MemoryShardCollectData> GetListShardCollectedOfMirror(int mirrorId)
	{
		return null;
	}

	private int ComparerShard(MemoryShardCollectData a, MemoryShardCollectData b)
	{
		return 0;
	}

	public PetCollectData AddNewPet(PetConfigId petConfigId)
	{
		return null;
	}

	private PetCollectData AddPetToCollect(PetConfigId configId, int collectID)
	{
		return null;
	}

	public PetCollectData GetPetCollectData(int collectId)
	{
		return null;
	}

	public List<PetCollectData> GetAllPetCollectDatas()
	{
		return null;
	}

	public List<ICollectData> GetPetList(IGetCollectDataRule rule = null, CollectDataComparer comparer = null)
	{
		return null;
	}

	public int TotalPetCount()
	{
		return 0;
	}

	public void RemovePet(PetCollectData petCollectData)
	{
	}

	public CraftingMaterial GetMaterial(Rarity rarity)
	{
		return null;
	}

	public CraftingMaterial GetMaterial(CraftingMaterialType type, Rarity rarity)
	{
		return null;
	}

	public int GetMaterialCount(Rarity rarity)
	{
		return 0;
	}

	public int GetMaterialCount(CraftingMaterialType type, Rarity rarity)
	{
		return 0;
	}

	public void AddMaterial(CraftingMaterialType type, Rarity rarity, int amount, RewardReason reason)
	{
	}

	public bool ConsumeMaterial(Rarity rarity, int amount, ConsumeCraftingMaterialReason reason)
	{
		return false;
	}

	public bool ConsumeMaterial(CraftingMaterialType type, Rarity rarity, int amount, ConsumeCraftingMaterialReason reason)
	{
		return false;
	}

	public List<ICollectData> GetMaterialList(IGetCollectDataRule rule = null, CollectDataComparer comparer = null)
	{
		return null;
	}

	private int FindAvailableCollectIdForMaterial()
	{
		return 0;
	}

	public List<CraftingMaterial> GetAllCraftingMaterials()
	{
		return null;
	}
}
