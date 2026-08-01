using Assets.Scripts.Ssar.Dungeon.GameModeLogic;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class InitDungeonInterfaceCmd : BaseShowPopupCmd
	{
		public static readonly string INJECT_NAME;

		[Inject]
		public IDungeonInterfaceLogic InterfaceLogic { get; set; }

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
