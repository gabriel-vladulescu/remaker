using Assets.Scripts.Ssar.CharacterSelection.Model;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic.Arena;
using Assets.Scripts.Ssar.Dungeon.Signal;
using SSAR.BattleSystem.System.Arena.Api;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class OnLoseArenaCmd : strange.extensions.command.impl.Command
	{
		private MainCharacterData saveData;

		[Inject]
		public ShowArenaLosePopupSignal ShowArenaLosePopupSignal { get; set; }

		[Inject]
		public ArenaModeParameter ArenaModeParameter { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}

		private void AddRecord(ArenaResultData result)
		{
		}

		private void Success(UpdateDuelResultData data)
		{
		}

		private ArenaResultData GenerateArenaLoseData(UserSeasonProgress before, UserSeasonProgress after, int rankBefore, int rankAfter)
		{
			return null;
		}

		private void LoseMetric(ArenaResultData arenaLoseData)
		{
		}

		private void MatchupMetric(CharacterCode main, CharacterCode opponent)
		{
		}

		private void UpdateFirstAnniversaryQuest()
		{
		}
	}
}
