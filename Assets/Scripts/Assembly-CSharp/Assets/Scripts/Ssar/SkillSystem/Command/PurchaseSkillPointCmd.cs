using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.SkillSystem.Command
{
	public class PurchaseSkillPointCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public int skillPoint { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}

		private void SendPurchaseSkillPointMetric(MainCharacterData mainCharacterData, DungeonConfig dungeonConfig, int totalSkillPointExcludePurchased)
		{
		}

		private GameConfigConstant Config()
		{
			return null;
		}
	}
}
