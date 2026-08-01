using System;
using Assets.Scripts.Ssar.Combat.Skills.Pool;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class VfxFollowBoneConfig
	{
		[PreloadPool.PrefabPathMarker]
		public string prefabPath;

		public float timeToLiveInSeconds;

		public string[] boneNames;
	}
}
