using System;
using System.Collections.Generic;

namespace SSAR.Entry.Model
{
	public class AskForRateNotify : AbsPopupNotify
	{
		private List<int> dungeonIds;

		public override void Process(Action onContinue, Action onBreak)
		{
		}

		public override bool IsNotify(string sceneName)
		{
			return false;
		}

		private bool ConditionToShowRatingPopUp()
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

		private int ConvertToSecond(double minutes)
		{
			return 0;
		}
	}
}
