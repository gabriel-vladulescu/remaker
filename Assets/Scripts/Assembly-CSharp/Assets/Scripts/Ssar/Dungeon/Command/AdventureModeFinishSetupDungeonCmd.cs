namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class AdventureModeFinishSetupDungeonCmd : BaseFinishSetupDungeonCmd
	{
		protected override void OnExcute()
		{
		}

		protected override bool DestroyLoadingScreen()
		{
			return false;
		}

		protected override void PlayAmbience()
		{
		}

		protected override void PlayBgm()
		{
		}
	}
}
