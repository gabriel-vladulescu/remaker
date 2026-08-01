using System;

namespace Assets.Scripts.Ssar.Combat.Effects
{
	[Serializable]
	public class SoundEffectConfig
	{
		public int frame;

		public string stateName;

		public string soundClipPath;

		public int intervalInFrames;

		public int order;
	}
}
