using Assets.Scripts.Ssar.AnniversaryEvent;
using SSAR.View;

namespace Ssar.Event
{
	public class MainSceneBtnEventNotify : AbsButtonNofity
	{
		private AnniversaryQuestNotiy anniversaryQuestNotiy;

		protected override void Awake()
		{
		}

		protected override bool IsNotify()
		{
			return false;
		}

		private bool AnniversaryLogin()
		{
			return false;
		}

		private bool AnniversaryQuest()
		{
			return false;
		}

		private bool XmasLogin()
		{
			return false;
		}

		private bool XmasWar()
		{
			return false;
		}

		private bool Campaign()
		{
			return false;
		}

		private bool EventWar()
		{
			return false;
		}

		private bool EventLogin()
		{
			return false;
		}
	}
}
