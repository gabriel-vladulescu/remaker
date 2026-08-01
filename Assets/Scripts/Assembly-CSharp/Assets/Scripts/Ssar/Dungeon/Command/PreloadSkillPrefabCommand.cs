using Assets.Scripts.Config.Stats;
using Assets.Scripts.Ssar.Common.System.Resources;
using Assets.Scripts.Ssar.Dungeon.Configs;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Scripts.Config;
using UnityEngine;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class PreloadSkillPrefabCommand : strange.extensions.command.impl.Command
	{
		private bool isHeroEquipCosmeticWeapon;

		private GameObject cosmeticWeaponPrefab;

		private HeroData heroData;

		private int level;

		private bool isFxFromCosmeticWeaponUsed;

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
	}
}
