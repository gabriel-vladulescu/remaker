using Scripts.Config;

namespace Assets.Scripts.Ssar.MemoryShard.Command
{
	public class ShowViewMemoryShardStoryPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public MirrorInfo MirrorInfo { get; set; }

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

		protected override PopupCamera GetCamera()
		{
			return default(PopupCamera);
		}
	}
}
