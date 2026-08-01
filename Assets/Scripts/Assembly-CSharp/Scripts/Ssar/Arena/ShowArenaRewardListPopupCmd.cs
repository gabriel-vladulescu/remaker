namespace Scripts.Ssar.Arena
{
	public class ShowArenaRewardListPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public int seasonCode { get; set; }

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
