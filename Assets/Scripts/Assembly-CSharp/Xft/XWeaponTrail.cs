using System.Collections.Generic;
using UnityEngine;

namespace Xft
{
	public class XWeaponTrail : MonoBehaviour
	{
		public class Element
		{
			public Vector3 PointStart;

			public Vector3 PointEnd;

			public Vector3 Pos => default(Vector3);

			public Element(Vector3 start, Vector3 end)
			{
			}

			public Element()
			{
			}
		}

		public static string Version;

		public Transform PointStart;

		public Transform PointEnd;

		public int MaxFrame;

		public int Granularity;

		public float Fps;

		public Color MyColor;

		public Material MyMaterial;

		protected float mTrailWidth;

		protected Element mHeadElem;

		protected List<Element> mSnapshotList;

		protected Spline mSpline;

		protected float mFadeT;

		protected bool mIsFading;

		protected float mFadeTime;

		protected float mElapsedTime;

		protected float mFadeElapsedime;

		protected GameObject mMeshObj;

		protected VertexPool mVertexPool;

		protected VertexPool.VertexSegment mVertexSegment;

		protected bool mInited;

		private bool recycleAfterFade;

		private GameObject recycleGo;

		public float UpdateInterval => 0f;

		public Vector3 CurHeadPos => default(Vector3);

		public float TrailWidth => 0f;

		public void Init()
		{
		}

		public void Activate()
		{
		}

		public void Deactivate()
		{
		}

		public void StopSmoothly(float fadeTime, bool recycleAfterFade = false, GameObject go = null)
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void Start()
		{
		}

		private void OnDrawGizmos()
		{
		}

		private void InitSpline()
		{
		}

		private void RefreshSpline()
		{
		}

		private void UpdateVertex()
		{
		}

		private void UpdateIndices()
		{
		}

		private void UpdateHeadElem()
		{
		}

		private void UpdateFade()
		{
		}

		private void RecordCurElem()
		{
		}

		private void InitOriginalElements()
		{
		}

		private void InitMeshObj()
		{
		}

		private void OnDisable()
		{
		}
	}
}
