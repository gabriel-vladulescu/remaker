using Assets.Scripts.Ssar.Dungeon.Command;
using SSAR.Dungeon.Model;

namespace Ssar.DailyChallenge.Command
{
	public class ShowChallengeWinCmd : ShowDungeonWinEffectCmd
	{
		[Inject]
		public ChallengeEndParametersWithDemonInvasion ParametersWithDemon { get; set; }

		protected override void ShowWinPopup(DungeonWinParameter parameter)
		{
		}
	}
}
