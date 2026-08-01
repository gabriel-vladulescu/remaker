using System;

namespace Assets.Scripts.Ssar.Command
{
	public class ShowRewardReceivePopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public ItemInfo ItemInfo { get; set; }

		[Inject]
		public Action onHide { get; set; }

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
