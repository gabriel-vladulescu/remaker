using Assets.Scripts.Config.Stats;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic.CharacterTestLevel;
using Assets.Scripts.Ssar.Dungeon.Model;
using SSAR.BattleSystem.Damage;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.api;
using strange.extensions.injector.api;
using strange.extensions.mediation.api;

namespace Assets.Scripts.Ssar.Dungeon.GameModeLogic.TestSkillMode
{
	public class TestSkillModeLogic : IBattleModeLogic
	{
		private readonly MainCharacterData _mainCharacterData;

		private global::Scripts.Config.Dungeon dungeon;

		private ConfigManager configManager;

		private DungeonConfig dungeonConfig;

		private TestSkillModeBattleInterfaceLogic interfaceLogic;

		private OnCharacterTestWinLogic adventureWinLogic;

		private OnCharacterTestLoseLogic adventureLoseLogic;

		private DefaultEquippedEquipmentVisualInfo itemVisualInfo;

		private Preset preset;

		public TestSkillModeLogic(MainCharacterData mainCharacterData, Preset preset)
		{
		}

		public void OnStartLoadScene()
		{
		}

		public void MapBindingContext(ICrossContextInjectionBinder injectionBinder, ICommandBinder commandBinder, IMediationBinder mediationBinder)
		{
		}

		protected virtual void ProtectMapBindingContext(ICrossContextInjectionBinder injectionBinder, ICommandBinder commandBinder, IMediationBinder mediationBinder)
		{
		}

		public IBattleEnvironmentAssetsPath BattleEnvironmentAssetsPath()
		{
			return null;
		}

		public MonsterData GenerateMonsterData(int groupId, int subId, int level, ConfigManager configManager)
		{
			return null;
		}

		public int CurrentlyEnterDungeonId()
		{
			return 0;
		}

		public IDungeonInfo CurrentlyEnterDungeonInfo()
		{
			return null;
		}

		public bool FindDungeonInfo(int id, ref IDungeonInfo di)
		{
			return false;
		}

		public BattleMode BattleMode()
		{
			return default(BattleMode);
		}

		public Stage GetStageInfo(int stageId)
		{
			return null;
		}

		public IOnBattleLoseLogic OnDungeonLoseLogic()
		{
			return null;
		}

		public IOnBattleWinLogic OnDungeonWinLogic()
		{
			return null;
		}

		public IBattleInterfaceLogic GetDungeonInterfaceLogic()
		{
			return null;
		}

		public IEquippedEquipmentVisualInfo EquippedEquipmentVisualInfo()
		{
			return null;
		}

		public IDungeonStartLogic GetDungeonStartLogic()
		{
			return null;
		}

		public bool IsCanResurrection()
		{
			return false;
		}

		public void SendUseHpPotionMetric(Metric metric, MainCharacterData mcd, HealthComponent healthComponent)
		{
		}

		public int KeyRequire()
		{
			return 0;
		}

		public MainCharacterData MainCharacterData()
		{
			return null;
		}

		public Preset GetPreset()
		{
			return default(Preset);
		}
	}
}
