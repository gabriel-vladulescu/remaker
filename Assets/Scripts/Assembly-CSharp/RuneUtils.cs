using SSAR.Equipment.Enum;
using Scripts.Config;
using Ssar.Reforge.Enum;
using Ssar.Rune.Model;

public static class RuneUtils
{
	public static readonly RuneType[] ForgeRuneTypes;

	public static RuneConfig GetRuneConfig()
	{
		return null;
	}

	public static RuneConfig.RuneItemConfig FindHigherRuneRarityItemConfig(RuneType runeType, RuneRarity runeRarity, RuneConfig runeConfig)
	{
		return null;
	}

	public static RuneConfig.RuneItemConfig FindLowerRuneRarityItemConfig(RuneType runeType, RuneRarity runeRarity, RuneConfig runeConfig)
	{
		return null;
	}

	public static string GetRuneStatDesc(RuneType runeType, RuneRarity runeRarity, EquipmentType equipmentType, bool showEquipmentType, bool useBBColor, RuneConfig runeConfig)
	{
		return null;
	}

	public static int GetRuneSellPrice(RuneType runeType, RuneRarity runeRarity, int amount, RuneConfig config)
	{
		return 0;
	}

	public static int GetUnequipRunePrice(RuneType runeType, RuneRarity runeRarity, RuneConfig config)
	{
		return 0;
	}

	public static int GetCombineRuneCost(RuneType runeType, RuneRarity runeRarity, int amount, RuneConfig runeConfig)
	{
		return 0;
	}

	public static Rune GenerateRandomRune(int randomRuneId, RandomRuneConfig randomRuneConfig)
	{
		return null;
	}

	public static ReforgeType ToReforgeType(this RuneType runeType)
	{
		return default(ReforgeType);
	}

	private static double GetStat(RuneType runeType, RuneRarity runeRarity, EquipmentType equipmentType, RuneConfig runeConfig)
	{
		return 0.0;
	}

	private static EquipmentType ConvertToEquipmentType(RuneType runeType)
	{
		return default(EquipmentType);
	}
}
