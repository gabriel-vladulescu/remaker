using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public class VfxFollowBone
	{
		private GameObject prefab;

		private float timeToLiveInSeconds;

		private string[] boneNames;

		public GameObject Prefab => null;

		public float TimeToLiveInSeconds => 0f;

		public string[] BoneNames => null;

		public VfxFollowBone(GameObject prefab, float timeToLiveInSeconds, string[] boneNames)
		{
		}
	}
}
