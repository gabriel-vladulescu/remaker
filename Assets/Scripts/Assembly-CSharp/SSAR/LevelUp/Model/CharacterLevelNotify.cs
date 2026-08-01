using System;

namespace SSAR.LevelUp.Model
{
	public class CharacterLevelNotify : AbsPopupNotify
	{
		public override void Process(Action onContinue, Action onBreak)
		{
		}

		public override bool IsNotify(string sceneName)
		{
			return false;
		}

		protected override void OnShow()
		{
		}

		public override string[] SceneActive()
		{
			return null;
		}

		public override bool IsByPassCheckTutorial()
		{
			return false;
		}
	}
}
