using SSAR.View;
using UnityEngine;

namespace Ssar.Event.Xmas
{
	public class MainSceneXmasOnlineNotify : AbsButtonNofity
	{
		public GameObject fxContainer;

		public UILabel content;

		protected override bool IsNotify()
		{
			return false;
		}

		protected override void Start()
		{
		}

		protected override void onEnable()
		{
		}

		protected override void CheckIconNotify()
		{
		}

		private void CheckClaimableTime()
		{
		}

		private void UpdateTimeDisplay()
		{
		}
	}
}
