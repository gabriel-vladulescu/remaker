using UnityEngine;

namespace SSAR.Dungeon.HUD
{
	[AddComponentMenu("NGUI/Examples/Follow Target")]
	public class UIFollowTarget : MonoBehaviour
	{
		public Transform target;

		public Camera gameCamera;

		public Camera uiCamera;

		public bool disableIfInvisible;

		public bool disableAffectVisible;

		private Transform mTrans;

		private bool mIsVisible;

		private Vector3 offset;

		private Vector3 offset3d;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void SetVisible(bool val)
		{
		}

		public void Setoffset2D(Vector3 offset)
		{
		}

		public void Setoffset3D(float offsetX)
		{
		}

		private void Update()
		{
		}

		protected virtual void OnUpdate(bool isVisible)
		{
		}
	}
}
