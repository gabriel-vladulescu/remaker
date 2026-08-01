using Assets.Scripts.Ssar.Common.System.Resources;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Assets.Scripts.Ssar.Dungeon.Model;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class InitBattleEnvirnomentCmd : strange.extensions.command.impl.Command
	{
		private int stack;

		[Inject]
		public ResourcesLoader ResourcesLoader { get; set; }

		[Inject]
		public IBattleModeLogic BattleModeLogic { get; set; }

		public override void Execute()
		{
		}

		private void LoadMainCamera(IBattleEnvironmentAssetsPath info, DungeonConfigCacheData configCache)
		{
		}

		private void LoadDungeonTerrain(IBattleEnvironmentAssetsPath info, DungeonConfigCacheData configcache)
		{
		}

		private void LoadDungeonTerrainCollider(IBattleEnvironmentAssetsPath info, DungeonConfigCacheData configcache)
		{
		}

		private void LoadDungeonConfig(IBattleEnvironmentAssetsPath info, DungeonConfigCacheData configcache)
		{
		}

		private void LoadDungeonStageCamera(IBattleEnvironmentAssetsPath info, DungeonConfigCacheData configcache)
		{
		}

		private void LoadEnvironmentInfluenecConfig(IBattleEnvironmentAssetsPath info, DungeonConfigCacheData configcache)
		{
		}

		private void Load(string path, AssetSuccessDelegate assetSuccess)
		{
		}

		private void UpdateProgress()
		{
		}
	}
}
