using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public class Vfx
	{
		private GameObject vfxPrefab;

		private bool followCasterPosition;

		private bool ignoreCasterPositionOnYAxis;

		private bool ignoreCasterDirection;

		private GameObject[] vfxPrefabs;

		private CoordinateOrigin coordinateOrigin;

		private Vector2 offset;

		public bool FollowCasterPosition => false;

		public GameObject[] VfxPrefabs => null;

		public bool IgnoreCasterPositionOnYAxis => false;

		public bool IgnoreCasterDirection => false;

		public CoordinateOrigin CoordinateOrigin => default(CoordinateOrigin);

		public Vector2 Offset => default(Vector2);

		public Vfx(GameObject[] vfxPrefabs, bool followCasterPosition, bool ignoreCasterPositionOnYAxis, bool ignoreCasterDirection, CoordinateOrigin coordinateOrigin, Vector2 offset)
		{
		}

		public GameObject VfxPrefab()
		{
			return null;
		}

		public GameObject RandomPrefab()
		{
			return null;
		}

		public void SetOffset(Vector2 offset)
		{
		}
	}
}
