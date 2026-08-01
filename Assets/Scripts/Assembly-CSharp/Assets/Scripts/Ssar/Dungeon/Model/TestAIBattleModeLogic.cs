using Assets.Scripts.Config.Stats;
using Assets.Scripts.Ssar.CharacterSelection.Model;
using Assets.Scripts.Ssar.Dungeon.Command;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic.CharacterTestLevel;
using SSAR.BattleSystem.Damage;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.api;
using strange.extensions.injector.api;
using strange.extensions.mediation.api;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class TestAIBattleModeLogic : IBattleModeLogic
	{
		private TestAIInMode mode;

		private IBattleEnvironmentAssetsPath iBattleEnvironmentAssetsPath;

		private int dungeonId;

		private IDungeonInfo dungeonInfo;

		private DungeonConfig dungeonConfig;

		private DefaultEquippedEquipmentVisualInfo defaultEquippedEquipmentVisualInfo;

		private CharacterTestModeBattleInterfaceLogic interfaceLogic;

		private OnCharacterTestWinLogic adventureWinLogic;

		private OnCharacterTestLoseLogic adventureLoseLogic;

		private CharacterCode characterCode;

		private ScenarioDifficulty difficulty;

		private ConfigManager configManager;

		public TestAIBattleModeLogic(TestAIInMode testAiInMode, ScenarioDifficulty difficulty, CharacterCode characterCode)
		{
		}

		public void OnStartLoadScene()
		{
		}

		public void MapBindingContext(ICrossContextInjectionBinder injectionBinder, ICommandBinder commandBinder, IMediationBinder mediationBinder)
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

		public InitDungeonSystemCmd.SpawnedMonsterList GetSpawnedMonsterList(Dungeon dungeon)
		{
			return null;
		}

		public TestAIInMode GetTestAiInMode()
		{
			return default(TestAIInMode);
		}

		public CharacterCode GetCharacterCode()
		{
			return default(CharacterCode);
		}
	}
}
