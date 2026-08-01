using System.Collections.Generic;
using UnityEngine;

namespace Xft
{
	public class VertexPool
	{
		public class VertexSegment
		{
			public int VertStart;

			public int IndexStart;

			public int VertCount;

			public int IndexCount;

			public VertexPool Pool;

			public VertexSegment(int start, int count, int istart, int icount, VertexPool pool)
			{
			}

			public void ClearIndices()
			{
			}
		}

		public Vector3[] Vertices;

		public int[] Indices;

		public Vector2[] UVs;

		public Color[] Colors;

		public Vector2[] UVs2;

		public bool IndiceChanged;

		public bool ColorChanged;

		public bool UVChanged;

		public bool VertChanged;

		public bool UV2Changed;

		public Mesh Mesh;

		public Material Material;

		protected int VertexTotal;

		protected int VertexUsed;

		protected int IndexTotal;

		protected int IndexUsed;

		public bool FirstUpdate;

		protected bool VertCountChanged;

		public const int BlockSize = 108;

		public float BoundsScheduleTime;

		public float ElapsedTime;

		protected List<VertexSegment> SegmentList;

		public void RecalculateBounds()
		{
		}

		public VertexPool(Mesh mesh, Material material)
		{
		}

		public VertexSegment GetRopeVertexSeg(int maxcount)
		{
			return null;
		}

		public Material GetMaterial()
		{
			return null;
		}

		public VertexSegment GetVertices(int vcount, int icount)
		{
			return null;
		}

		private void InitDefaultShaderParam(Vector2[] uv2)
		{
		}

		protected void InitArrays()
		{
		}

		public void EnlargeArrays(int count, int icount)
		{
		}

		public void LateUpdate()
		{
		}
	}
}
