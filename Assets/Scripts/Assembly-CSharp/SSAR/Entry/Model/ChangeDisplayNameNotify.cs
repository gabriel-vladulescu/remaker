using System;

namespace SSAR.Entry.Model
{
	public class ChangeDisplayNameNotify : AbsPopupNotify
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

		public override bool IsByPassCheckTutorial()
		{
			return false;
		}
	}
}
