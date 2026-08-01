using Assets.Scripts.Ssar.Dungeon.Command;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class TestAIFinishSetupDungeonCmd : BaseFinishSetupDungeonCmd
	{
		protected override void OnExcute()
		{
		}

		protected override void PlayAmbience()
		{
		}

		protected override void PlayBgm()
		{
		}

		protected override bool EnableDungeonUpdate()
		{
			return false;
		}
	}
}
