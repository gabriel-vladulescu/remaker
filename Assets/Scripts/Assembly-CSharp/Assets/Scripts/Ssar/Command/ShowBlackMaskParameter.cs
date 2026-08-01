using System;

namespace Assets.Scripts.Ssar.Command
{
	public class ShowBlackMaskParameter
	{
		public float duration;

		public float toAlpha;

		public float fromAlpha;

		public bool disableWhenFinish;

		public Action onFinish;

		public ShowBlackMaskParameter(float duration, float fromAlpha, float toAlpha, bool disableWhenFinish, Action onFinishAction = null)
		{
		}
	}
}
