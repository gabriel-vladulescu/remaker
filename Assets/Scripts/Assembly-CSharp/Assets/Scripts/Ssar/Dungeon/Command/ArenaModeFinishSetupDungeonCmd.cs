using Assets.Scripts.Ssar.Dungeon.Signal;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class ArenaModeFinishSetupDungeonCmd : BaseFinishSetupDungeonCmd
	{
		[Inject]
		public StopAllAISignal StopAllAiSignal { get; set; }

		protected override void OnExcute()
		{
		}

		protected override void PlayAmbience()
		{
		}

		protected override void PlayBgm()
		{
		}
	}
}
