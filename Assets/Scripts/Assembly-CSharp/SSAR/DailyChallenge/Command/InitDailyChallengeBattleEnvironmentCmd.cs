using System;
using Assets.Scripts.Ssar.Common.System.Resources;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Assets.Scripts.Ssar.Dungeon.Model;
using Scripts.Config;
using Ssar.DailyChallenge.Model;
using UnityEngine;
using strange.extensions.command.impl;

namespace Ssar.DailyChallenge.Command
{
	public class InitDailyChallengeBattleEnvironmentCmd : strange.extensions.command.impl.Command
	{
		private class LoadedData
		{
			public readonly int index;

			public DailyChallengeConfig.Sample config;

			public readonly GameObject asset;

			public LoadedData(int index, DailyChallengeConfig.Sample config, GameObject asset)
			{
			}
		}

		public DailyChallengeConfig config;

		private int stack;

		private int loadingStack;

		[Inject]
		public ResourcesLoader ResourcesLoader { get; set; }

		[Inject]
		public IBattleModeLogic BattleModeLogic { get; set; }

		[Inject]
		public ConfigManager ConfigManager { get; set; }

		public override void Execute()
		{
		}

		private void Load(int index, DailyChallengeConfig.Sample source, Action<LoadedData> assetSuccess)
		{
		}

		private void UpdateProgress()
		{
		}

		private void LoadDungeonConfig(int[] roundIds, IBattleEnvironmentAssetsPath info, DungeonConfigCacheData configcache)
		{
		}

		private void ImportStageData(LoadedData data, DailyChallengeConfigInspector configInspector)
		{
		}

		private void RebuildDungeonConfig(DailyChallengeConfigInspector configInspector, IBattleEnvironmentAssetsPath info, DungeonConfigCacheData configcache)
		{
		}
	}
}
