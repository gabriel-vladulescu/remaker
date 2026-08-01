using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Effects
{
	public class EffectFollowAnimationConfig : MonoBehaviour
	{
		public enum Mode
		{
			Spine2D = 0,
			Animation3D = 1
		}

		public Mode animMode;

		public List<AnimationConfig> animationConfigs;

		public List<SoundAnimationConfig> soundAnimationConfigs;

		public List<CameraAnimationConfig> cameraAnimationConfigs;

		public List<string> AnimationNames()
		{
			return null;
		}

		public int IndexOfAnimation(string animationName)
		{
			return 0;
		}
	}
}
