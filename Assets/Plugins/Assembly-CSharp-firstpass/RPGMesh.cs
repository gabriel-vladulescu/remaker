using System;
using System.Collections.Generic;
using UnityEngine;

[Obsolete("RPGMesh has been replaced by BSPTree")]
[RequireComponent(typeof(MeshCollider))]
[RequireComponent(typeof(MeshFilter))]
public class RPGMesh : MonoBehaviour
{
	private static Dictionary<int, RPGTriangleTree> triangleTrees;

	private int meshId;

	private Mesh sharedMesh;

	private Color color;

	private List<int> triangles;

	private void Start()
	{
	}

	public Vector3 ClosestPointOn(Vector3 to, float bodyRadius, bool displayDebugInfo, bool displayExtendedDebugInfo)
	{
		return default(Vector3);
	}

	private bool SameSide(Vector3 p1, Vector3 p2, Vector3 a, Vector3 b)
	{
		return false;
	}

	private bool PointLiesInTriangle(Vector3 pt, Vector3 a, Vector3 b, Vector3 c)
	{
		return false;
	}

	private void ClosestPointOnTriangleToPoint(ref Vector3 vertex1, ref Vector3 vertex2, ref Vector3 vertex3, ref Vector3 point, out Vector3 result)
	{
		result = default(Vector3);
	}
}
