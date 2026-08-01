using UnityEngine;

[RequireComponent(typeof(MeshCollider))]
public class BruteForceMesh : MonoBehaviour
{
	private int triangleCount;

	private Vector3[] vertices;

	private int[] tris;

	private Vector3[] triangleNormals;

	private Mesh mesh;

	private void Awake()
	{
	}

	public Vector3 ClosestPointOn(Vector3 to)
	{
		return default(Vector3);
	}

	private Vector3 ClosestPointOnTriangle(int[] triangles, Vector3 to)
	{
		return default(Vector3);
	}

	private void ClosestPointOnTriangleToPoint(ref Vector3 vertex1, ref Vector3 vertex2, ref Vector3 vertex3, ref Vector3 point, out Vector3 result)
	{
		result = default(Vector3);
	}
}
