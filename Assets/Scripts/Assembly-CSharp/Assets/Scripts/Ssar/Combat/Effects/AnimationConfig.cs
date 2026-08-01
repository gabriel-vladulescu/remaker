using System;
using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Combat.Effects
{
	[Serializable]
	public class AnimationConfig
	{
		public string animationName;

		public List<EffectConfig> effectConfigs;

		public List<SoundAnimationConfig> soundConfigs;
	}
}
