using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class MapColliderBoundariesConfig : MonoBehaviour
	{
		public GameObject left;

		public GameObject right;

		public GameObject top;

		public GameObject bottom;

		private List<BoxCollider> colliders;

		public Vector3 ClampPositionToGround(Vector3 position)
		{
			return default(Vector3);
		}

		private List<BoxCollider> GetColliders()
		{
			return null;
		}

		private int Comparer(Collider a, Collider b)
		{
			return 0;
		}

		private bool IsInRange(Vector3 position, Collider collider)
		{
			return false;
		}

		private float GetTopPos(BoxCollider col)
		{
			return 0f;
		}
	}
}
