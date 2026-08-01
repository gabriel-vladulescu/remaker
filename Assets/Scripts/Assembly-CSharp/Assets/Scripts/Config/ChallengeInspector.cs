using System;

namespace Assets.Scripts.Config
{
	[Serializable]
	public class ChallengeInspector
	{
		public int wave;

		public TriggerInspector startTrigger;

		public TriggerInspector mainTrigger;
	}
}
