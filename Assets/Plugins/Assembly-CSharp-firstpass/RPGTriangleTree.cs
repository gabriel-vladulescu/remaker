using System.Collections.Generic;
using UnityEngine;

public class RPGTriangleTree
{
	public struct Triangle
	{
		public int Index0;

		public int Index1;

		public int Index2;

		public Vector3 Center;

		public Vector3 Extents;

		public Vector3 Min => default(Vector3);

		public Vector3 Max => default(Vector3);
	}

	public struct Node
	{
		public const int LEFT_TOP_FRONT = 0;

		public const int RIGHT_TOP_FRONT = 1;

		public const int LEFT_TOP_BACK = 2;

		public const int RIGHT_TOP_BACK = 3;

		public const int LEFT_BOTTOM_FRONT = 4;

		public const int RIGHT_BOTTOM_FRONT = 5;

		public const int LEFT_BOTTOM_BACK = 6;

		public const int RIGHT_BOTTOM_BACK = 7;

		public Vector3 Center;

		public Vector3 Extents;

		public Node[] Children;

		public int[] Triangles;

		public Vector3 Min => default(Vector3);

		public Vector3 Max => default(Vector3);

		public void Init(Vector3 center, Vector3 extents)
		{
		}

		public static void Split(ref Node node)
		{
		}

		public static void Insert(ref Node n, Triangle[] ts, int t)
		{
		}

		public static void FindClosestNodes(ref Node n, ref Vector3 p, float r, List<Node> result)
		{
		}

		public static void FindClosestTriangles(ref Node n, ref Vector3 p, float r, List<int> result)
		{
		}

		public static bool IntersectsTriangle(ref Node n, ref Triangle t)
		{
			return false;
		}

		public static bool IntersectsSphere(ref Node node, ref Vector3 p, float radius)
		{
			return false;
		}

		private static Vector3 clampVector(Vector3 value, Vector3 min, Vector3 max)
		{
			return default(Vector3);
		}
	}

	public Node Root;

	public readonly int TriangleCount;

	public readonly int VertexCount;

	public readonly Vector3[] Vertices;

	public readonly Triangle[] Triangles;

	public readonly float Size;

	public RPGTriangleTree(MeshCollider mc)
	{
	}

	public void GetTrianglePoints(int n, out Vector3 p0, out Vector3 p1, out Vector3 p2)
	{
		p0 = default(Vector3);
		p1 = default(Vector3);
		p2 = default(Vector3);
	}

	public Vector3[] GetTrianglePoints(int n)
	{
		return null;
	}

	public static void FromPoints(Vector3[] points, out Vector3 center, out Vector3 extents)
	{
		center = default(Vector3);
		extents = default(Vector3);
	}

	public void DrawGizmos()
	{
	}

	public void FindClosestNodes(Vector3 p, float r, List<Node> result)
	{
	}

	public void FindClosestTriangles(Vector3 p, float r, List<int> result)
	{
	}

	private void DrawGizmos(ref Node node)
	{
	}
}
