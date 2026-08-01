using SSAR.View;

namespace Ssar.Event.SevenDaysCampaign.View
{
	public class CampaignPopupTabNotify : AbsButtonNofity
	{
		private int day;

		protected override bool IsNotify()
		{
			return false;
		}

		internal void Init(int day)
		{
		}
	}
}
