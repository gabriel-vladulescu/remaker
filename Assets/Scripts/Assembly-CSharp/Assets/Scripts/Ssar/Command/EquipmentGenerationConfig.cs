using Scripts.Config;

namespace Assets.Scripts.Ssar.Command
{
	public class EquipmentGenerationConfig
	{
		private ConfigManager configManager;

		public EquipmentGenerationConfig(ConfigManager configManager)
		{
		}

		public JsonEquipmentDropConfig GetEquipmentGenerationConfig(int groupId, int subId)
		{
			return null;
		}

		public JsonCosmeticEquipmentDropConfig GetCosmeticEquipmentGenerationConfig(int groupId, int subId)
		{
			return null;
		}

		public AncientEquipmentConfig GetAncientEquipmentConfig()
		{
			return null;
		}
	}
}
