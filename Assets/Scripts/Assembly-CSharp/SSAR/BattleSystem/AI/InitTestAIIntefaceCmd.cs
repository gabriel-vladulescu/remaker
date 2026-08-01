using Assets.Scripts.Ssar.Dungeon.Configs;

namespace SSAR.BattleSystem.AI
{
	public class InitTestAIIntefaceCmd : BaseShowPopupCmd
	{
		[Inject]
		public DungeonConfig DungeonConfig { get; set; }

		public override void Execute()
		{
		}

		protected override string GetAssetPath()
		{
			return null;
		}

		protected override string GetInjectName()
		{
			return null;
		}
	}
}
