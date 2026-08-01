using SSAR.Equipment.Enum;
using Scripts.Config;
using Ssar.Rune.Model;

namespace Ssar.Craft.Model
{
	public class CraftableItem
	{
		private int id;

		private ItemType itemType;

		private RuneType runeType;

		private EquipmentType equipmentType;

		private Rarity rarity;

		private int visualID;

		private ICollectData collectData;

		private string rawSubType;

		public int RecipeID => 0;

		public ItemType ItemType => default(ItemType);

		public string RawSubType => null;

		public RuneType RuneType => default(RuneType);

		public EquipmentType EquipmentType => default(EquipmentType);

		public Rarity Rarity => default(Rarity);

		public int VisualID => 0;

		public ICollectData CollectData => null;

		public CraftableItem(CraftConfig.CraftRecipe recipe, int visualID)
		{
		}

		public void InitEquipment(EquipmentType equipmentType, Rarity rarity, int visualID)
		{
		}

		public void InitRune(RuneType runeType, Rarity rarity)
		{
		}
	}
}
