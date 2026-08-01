using Assets.Scripts.Ssar.Signal;
using Ssar.DailyChallenge.Model;
using Ssar.RaidBoss.Model;

namespace Assets.Scripts.Ssar.Dungeon.Signal
{
	public class DungeonSignalManager
	{
		[Inject]
		public ClickButtonSkillSignal ButtonSkillSignal { get; set; }

		[Inject]
		public PauseDungeonTimeSignal PauseDungeonTimeSignal { get; set; }

		[Inject]
		public SpawnMonsterSignal SpawnMonsterSignal { get; set; }

		[Inject]
		public OnEnterDungeonStageSignal OnEnterDungeonStageSignal { get; set; }

		[Inject]
		public ShowDungeonPausePopupSignal ShowDungeonPausePopupSignal { get; set; }

		[Inject]
		public CheckDungeonCanResurrectionSignal CheckDungeonCanResurrectionSignal { get; set; }

		[Inject]
		public ShowdDungeonResurrectionPopupSignal ShowdDungeonResurrectionPopupSignal { get; set; }

		[Inject]
		public MainCharacterDeathSignal MainCharacterDeathSignal { get; set; }

		[Inject]
		public StopAllAISignal StopAllAiSignal { get; set; }

		[Inject]
		public MainCharacterResurrectionSuccessSignal MainCharacterResurrectionSuccessSignal { get; set; }

		[Inject]
		public ShowDungeonLosePopupSignal ShowDungeonLosePopupSignal { get; set; }

		[Inject]
		public ShowDungeonWinPopupSignal ShowDungeonWinPopupSignal { get; set; }

		[Inject]
		public DungeonWinSignal DungeonWinSignal { get; set; }

		[Inject]
		public UpdateDungeonObjectiveListStageSignal UpdateDungeonObjectiveListStageSignal { get; set; }

		[Inject]
		public UpdateDungeonObjectiveStageItemViewSignal UpdateDungeonObjectiveStageItemViewSignal { get; set; }

		[Inject]
		public ClearAllCoprseSignal ClearAllCoprseSignal { get; set; }

		[Inject]
		public OnDungeonStageClearSignal OnDungeonStageClearSignal { get; set; }

		[Inject]
		public StartBossWarningEffectSignal StartBossWarningEffectSignal { get; set; }

		[Inject]
		public ShowBossNamePopupSignal ShowBossNamePopupSignal { get; set; }

		[Inject]
		public HideBossNamePopupSignal HideBossNamePopupSignal { get; set; }

		[Inject]
		public DisableInputAndAISignal DisableInputAndAiSignal { get; set; }

		[Inject]
		public FinishSpawnMonsterSignal FinishSpawnMonsterSignal { get; set; }

		[Inject]
		public DungeonFailedSignal DungeonFailedSignal { get; set; }

		[Inject]
		public ShowDungeonPickupPopupSignal ShowDungeonPickupPopupSignal { get; set; }

		[Inject]
		public UseHpPotionSignal UseHpPotionSignal { get; set; }

		[Inject]
		public SetEnableWarningMaskSignal SetEnableWarningMaskSignal { get; set; }

		[Inject]
		public UpdateMainCharacterHealthSignal UpdateMainCharacterHealthSignal { get; set; }

		[Inject]
		public ShowJoyStickSignal ShowJoyStickSignal { get; set; }

		[Inject]
		public StopMoveJoyStickSignal StopMoveJoyStickSignal { get; set; }

		[Inject]
		public HideMainCharacterHealthInfoSignal HideMainCharacterHealthInfoSignal { get; set; }

		[Inject]
		public HideDungeonObjectiveSignal HideDungeonObjectiveSignal { get; set; }

		[Inject]
		public HideDungeonStageViewSignal HideDungeonStageViewSignal { get; set; }

		[Inject]
		public HideUserButtonSignal HideUserButtonSignal { get; set; }

		[Inject]
		public ShowDungeonEffectGoNextStageSignal ShowDungeonEffectGoNextStageSignal { get; set; }

		[Inject]
		public HideHpPotionViewSignal HideHpPotionViewSignal { get; set; }

		[Inject]
		public ShowButtonAttackSignal ShowButtonAttackSignal { get; set; }

		[Inject]
		public ShowButtonJumpSignal ShowButtonJumpSignal { get; set; }

		[Inject]
		public ShowButtonDashSignal ShowButtonDashSignal { get; set; }

		[Inject]
		public ShowButtonSkillSignal ShowButtonSkillSignal { get; set; }

		[Inject]
		public HideAllButtonAndOnlyShowLobbySignal HideAllButtonAndOnlyShowLobbySignal { get; set; }

		[Inject]
		public ClickBtnLobbySignal ClickBtnLobbySignal { get; set; }

		[Inject]
		public ReceiveX2ItemSignal ReceiveX2ItemSignal { get; set; }

		[Inject]
		public ShowDungeonWinBonusRewardPopupSignal ShowDungeonWinBonusRewardPopupSignal { get; set; }

		[Inject]
		public ChangeDungeonWaveSignal ChangeDungeonWaveSignal { get; set; }

		[Inject]
		public OnChangeDungeonWaveSignal OnChangeDungeonWaveSignal { get; set; }

		[Inject]
		public WatchVodGainBonusItemSignal WatchVodGainBonusItemSignal { get; set; }

		[Inject]
		public WatchVodRetainResourcesSignal WatchVodRetainResourcesSignal { get; set; }

		[Inject]
		public SpawnPlayerCorpseSignal SpawnPlayerCorpseSignal { get; set; }

		[Inject]
		public ShowPlayerCorpsePopupSignal ShowPlayerCorpsePopupSignal { get; set; }

		[Inject]
		public PrayPlayerCorpseSignal PrayPlayerCorpseSignal { get; set; }

		[Inject]
		public CursePlayerCorpseSignal CursePlayerCorpseSignal { get; set; }

		[Inject]
		public SetEnableAISignal SetEnableAiSignal { get; set; }

		[Inject]
		public InitDungeonInterfaceSignal InitDungeonInterfaceSignal { get; set; }

		[Inject]
		public InitArenaInterfaceSignal InitArenaInterfaceSignal { get; set; }

		[Inject]
		public LoseBattleSignal LoseBattleSignal { get; set; }

		[Inject]
		public OnSpawnPetOfEntitySignal OnSpawnPetOfEntitySignal { get; set; }

		[Inject]
		public UpdateFirstAnniversaryQuestProgressSignal UpdateFirstAnniversaryQuestProgressSignal { get; set; }

		[Inject]
		public UpdateArcaneFormRemainingDurationSignal UpdateArcaneFormRemainingDurationSignal { get; set; }

		[Inject]
		public BackToNormalFormSignal BackToNormalFormSignal { get; set; }

		[Inject]
		public ChangeToArcaneFormSignal ChangeToArcaneFormSignal { get; set; }

		[Inject]
		public ArcaneFormReduceDurationByTakingDamageSignal ArcaneFormReduceDurationByTakingDamageSignal { get; set; }

		[Inject]
		public OnUsedAncientSkillSignal OnUsedAncientSkillSignal { get; set; }

		[Inject]
		public ShowDuelArenaWinPopupSignal ShowDuelArenaWinPopupSignal { get; set; }

		[Inject]
		public ShowDungeonWinEffectSignal ShowDungeonWinEffectSignal { get; set; }

		[Inject]
		public PlayArenaWinEffectSignal PlayArenaWinEffectSignal { get; set; }

		[Inject]
		public OnArenaStartBattleSignal OnArenaStartSignal { get; set; }

		[Inject]
		public OnLoseArenaSignal OnLoseArenaSignal { get; set; }

		[Inject]
		public OnWinArenaSignal OnWinArenaSignal { get; set; }

		[Inject]
		public ShowArenaOpponentInfoPopupSignal ShowArenaOpponentInfoPopupSignal { get; set; }

		[Inject]
		public HideArenaOpponentInfoPopupSignal HideArenaOpponentInfoPopupSignal { get; set; }

		[Inject]
		public SelectArenaRuneSignal SelectArenaRuneSignal { get; set; }

		[Inject]
		public OnDungeonStartSignal OnDungeonStartSignal { get; set; }

		[Inject]
		public OnWinArenaInReplayModeSignal OnWinArenaInReplayModeSignal { get; set; }

		[Inject]
		public OnLoseArenaInReplayModeSignal OnLoseArenaInReplayModeSignal { get; set; }

		[Inject]
		public ShowArenaVersusPopupSignal ShowArenaVersusPopupSignal { get; set; }

		[Inject]
		public ShowRaidWinSignal ShowRaidWinSignal { get; set; }

		[Inject]
		public ShowRaidWinPopupSignal ShowRaidWinPopupSignal { get; set; }

		[Inject]
		public ShowChallengeWinSignal ShowChallengeWinSignal { get; set; }

		[Inject]
		public ShowChallengeWinPopupSignal ShowChallengeWinPopupSignal { get; set; }
	}
}
