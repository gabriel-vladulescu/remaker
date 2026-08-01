using Scripts.Config;

namespace Assets.Scripts.Ssar.Entry
{
	public class Character2GenerateEquipmentLogic : AbsCharacterGenerateEquipmentLogic
	{
		private JsonRandomEquipmentConfig jsonRandomEquipmentConfig;

		private JsonEquipmentDropConfig jsonEquipmentDropConfig;

		private JsonCosmeticEquipmentDropConfig jsonCosmeticEquipmentDropConfig;

		private AncientEquipmentConfig ancientEquipmentConfig;

		private EquipmentVisualConfig equipmentVisualConfig;

		private GameConfigConstant gameConfigConstant;

		public Character2GenerateEquipmentLogic(ConfigManager configManager)
		{
		}

		protected override int CharacterGroupId()
		{
			return 0;
		}

		protected override int CharacterSubId()
		{
			return 0;
		}

		public override JsonRandomEquipmentConfig RandomEquipmentConfig()
		{
			return null;
		}

		public override JsonEquipmentDropConfig EquipmentDropConfig()
		{
			return null;
		}

		public override JsonCosmeticEquipmentDropConfig CosmeticDropConfig()
		{
			return null;
		}

		public override AncientEquipmentConfig AncientEquipmentConfig()
		{
			return null;
		}

		protected override EquipmentVisualConfig EquipmentVisualConfig()
		{
			return null;
		}

		protected override GameConfigConstant GameConfigConstant()
		{
			return null;
		}
	}
}
