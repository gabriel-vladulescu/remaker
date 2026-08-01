using System.Collections.Generic;
using Assets.Scripts.Ssar.Combat.Skills.Pool;
using Assets.Scripts.Ssar.Common.System.Resources;
using Assets.Scripts.Ssar.Dungeon.Configs;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Assets.Scripts.Ssar.Dungeon.Model;
using SSAR.BattleSystem.Effect;
using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class CheckAndInitPlayerCorpseTombCmd : strange.extensions.command.impl.Command
	{
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

		public override void Execute()
		{
		}

		private PlayerCorpseData GetPlayerCorpseData()
		{
			return null;
		}

		public void InitEffectPool()
		{
		}

		private void InitEffectPool(List<PrefabItem> prefabItems, EffectEditorInfo[] eeis)
		{
		}
	}
}
