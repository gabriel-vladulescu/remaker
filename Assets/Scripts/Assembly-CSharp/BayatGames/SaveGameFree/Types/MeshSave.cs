using System;
using UnityEngine;

namespace BayatGames.SaveGameFree.Types
{
	[Serializable]
	public class MeshSave
	{
		public Vector3Save[] vertices;

		public int[] triangles;

		public Vector2Save[] uv;

		public Vector3Save[] normals;

		public Color[] colors;

		public Color32[] colors32;

		public MeshSave(Mesh mesh)
		{
		}

		public static implicit operator MeshSave(Mesh mesh)
		{
			return null;
		}

		public static implicit operator Mesh(MeshSave mesh)
		{
			return null;
		}
	}
}
