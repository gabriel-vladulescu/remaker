using System;

namespace SSAR.Entry.Model
{
	public class AskForSaveNotify : AbsPopupNotify
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

		private int ConvertToSecond(double minutes)
		{
			return 0;
		}
	}
}
