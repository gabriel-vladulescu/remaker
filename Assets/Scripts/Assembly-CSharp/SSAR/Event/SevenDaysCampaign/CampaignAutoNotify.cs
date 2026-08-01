using System;

namespace Ssar.Event.SevenDaysCampaign
{
	public class CampaignAutoNotify : AbsPopupNotify
	{
		public override void Process(Action onContinue, Action onBreak)
		{
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
