namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class ShowDungeonLosePopupParameters
	{
		public DungeonLoseReason Reason;

		public bool enableVideo;

		public ShowDungeonLosePopupParameters(DungeonLoseReason reason)
		{
		}

		public ShowDungeonLosePopupParameters(DungeonLoseReason reason, bool enableVideo)
		{
		}
	}
}
