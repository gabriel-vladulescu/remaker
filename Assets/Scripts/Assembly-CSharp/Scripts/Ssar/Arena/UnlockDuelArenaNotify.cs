using System;

namespace Scripts.Ssar.Arena
{
	public class UnlockDuelArenaNotify : AbsPopupNotify
	{
		private MainCharacterData mainCharacterData;

		private FeatureName featureName;

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
