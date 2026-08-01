using Assets.Scripts.Config.Stats;
using Assets.Scripts.Ssar.Dungeon.Model;
using SSAR.BattleSystem.Damage;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.api;
using strange.extensions.injector.api;
using strange.extensions.mediation.api;

namespace Assets.Scripts.Ssar.Dungeon.GameModeLogic
{
	public interface IBattleModeLogic
	{
		void OnStartLoadScene();

		void MapBindingContext(ICrossContextInjectionBinder injectionBinder, ICommandBinder commandBinder, IMediationBinder mediationBinder);

		IBattleEnvironmentAssetsPath BattleEnvironmentAssetsPath();

		MonsterData GenerateMonsterData(int groupId, int subId, int level, ConfigManager configManager);

		int CurrentlyEnterDungeonId();

		IDungeonInfo CurrentlyEnterDungeonInfo();

		bool FindDungeonInfo(int id, ref IDungeonInfo di);

		BattleMode BattleMode();

		Stage GetStageInfo(int stageId);

		IOnBattleLoseLogic OnDungeonLoseLogic();

		IOnBattleWinLogic OnDungeonWinLogic();

		IBattleInterfaceLogic GetDungeonInterfaceLogic();

		IEquippedEquipmentVisualInfo EquippedEquipmentVisualInfo();

		IDungeonStartLogic GetDungeonStartLogic();

		bool IsCanResurrection();

		void SendUseHpPotionMetric(Metric metric, MainCharacterData mcd, HealthComponent healthComponent);

		int KeyRequire();

		MainCharacterData MainCharacterData();

		Preset GetPreset();
	}
}
