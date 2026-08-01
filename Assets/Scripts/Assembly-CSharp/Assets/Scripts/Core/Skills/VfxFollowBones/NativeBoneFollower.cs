using UnityEngine;

namespace Assets.Scripts.Core.Skills.VfxFollowBones
{
	public class NativeBoneFollower : MonoBehaviour
	{
		private string boneName;

		private GameObject root;

		private GameObject bone;

		public Vector3 RotationOffset;

		public bool UpdateValues(string boneName, GameObject root)
		{
			return false;
		}

		public void Disable()
		{
		}

		public void SetScale(Vector3 offset)
		{
		}

		public void LateUpdate()
		{
		}
	}
}
