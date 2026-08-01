using Assets.Scripts.Ssar.Dungeon.Model;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class ShowPlayerCorpsePopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public PlayerCorpseData PlayerCorpseData { get; set; }

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
