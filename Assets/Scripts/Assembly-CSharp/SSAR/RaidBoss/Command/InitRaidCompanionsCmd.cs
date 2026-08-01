using System.Collections.Generic;
using Assets.Scripts.Ssar.Combat.Skills.Pool;
using Assets.Scripts.Ssar.Common.System.Resources;
using Assets.Scripts.Ssar.Dungeon.Configs;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Scripts.Config;
using Ssar.RaidBoss.Model;
using strange.extensions.command.impl;

namespace Ssar.RaidBoss.Command
{
	public class InitRaidCompanionsCmd : strange.extensions.command.impl.Command
	{
		private List<RaidTeamData.Companion> companions;

		private int companionCount;

		[Inject]
		public PreloadPool preloadPool { get; set; }

		[Inject]
		public ResourcesLoader resourcesLoader { get; set; }

		[Inject]
		public Assets.Scripts.Ssar.Dungeon.Configs.DungeonConfig dungeonConfig { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public IBattleModeLogic battleModeLogic { get; set; }

		[Inject]
		public SpawnRaidCompanionSignal SpawnRaidCompanionSignal { get; set; }

		public override void Execute()
		{
		}

		private void InitCompanion()
		{
		}

		private void InitEffectPool(List<PrefabItem> prefabItems)
		{
		}

		private void SpawnCompanion(RaidTeamData.Companion companion)
		{
		}
	}
}
