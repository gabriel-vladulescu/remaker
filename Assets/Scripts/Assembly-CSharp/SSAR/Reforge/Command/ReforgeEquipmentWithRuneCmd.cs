using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using Scripts.Config;
using Ssar.Achievement;
using Ssar.Analytics.Metrics;
using Ssar.Reforge.Enum;
using Ssar.Rune;
using Ssar.Rune.Model;
using strange.extensions.command.impl;

namespace Ssar.Reforge.Command
{
	public class ReforgeEquipmentWithRuneCmd : strange.extensions.command.impl.Command
	{
		private int runeConsumeQuantity;

		[Inject]
		public EquipmentCollectData equipmentCollectData { get; set; }

		[Inject]
		public Ssar.Rune.Model.Rune Rune { get; set; }

		[Inject]
		public OnReforgeEquipmentWithRuneSuccessSignal OnSuccessSignal { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public AchievementLogic achievementLogic { get; set; }

		public override void Execute()
		{
		}

		private void Reforge()
		{
		}

		private EquipmentCollectData CreateReforgedEquipment(out ReforgeType reforgeType)
		{
			reforgeType = default(ReforgeType);
			return null;
		}

		private EquipmentConfigId Reforge(ReforgeType reforgeType)
		{
			return null;
		}

		private EquipmentCollectData GetCloneEquipment()
		{
			return null;
		}

		private bool RemoveRune()
		{
			return false;
		}

		private bool IsDirectReforge(ReforgeType reforgeType)
		{
			return false;
		}

		private bool IsEnableKeep(ReforgeType reforgeType)
		{
			return false;
		}

		private void SendReforgeMetric(ReforgeType runeType, EquipmentType equipmentType, Rarity rarity)
		{
		}
	}
}
