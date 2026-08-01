using System;
using PigeonCoopToolkit.Utillities;
using UnityEngine;

namespace PigeonCoopToolkit.Effects.Trails
{
	public class PCTrail : IDisposable
	{
		public CircularBuffer<PCTrailPoint> Points;

		public Mesh Mesh;

		public Vector3[] verticies;

		public Vector3[] normals;

		public Vector2[] uvs;

		public Color[] colors;

		public int[] indicies;

		public int activePointCount;

		public bool IsActiveTrail;

		public PCTrail(int numPoints)
		{
		}

		public void Dispose()
		{
		}
	}
}
