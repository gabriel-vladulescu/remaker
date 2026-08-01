using System;

namespace SSAR.Entry.Model
{
	public class XmasEventBannerNotify : AbsPopupNotify
	{
		public override void Process(Action onContinue, Action onBreak)
		{
		}

		public bool IsEnableEvent()
		{
			return false;
		}

		public override bool IsNotify(string sceneName)
		{
			return false;
		}

		public override string[] SceneActive()
		{
			return null;
		}

		protected override void OnShow()
		{
		}
	}
}
