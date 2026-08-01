using System;
using UnityEngine;

namespace BayatGames.SaveGameFree.Types
{
	[Serializable]
	public struct Vector2Save
	{
		public float x;

		public float y;

		public Vector2Save(float x)
		{
			this.x = 0f;
			y = 0f;
		}

		public Vector2Save(float x, float y)
		{
			this.x = 0f;
			this.y = 0f;
		}

		public Vector2Save(Vector2 vector)
		{
			x = 0f;
			y = 0f;
		}

		public Vector2Save(Vector3 vector)
		{
			x = 0f;
			y = 0f;
		}

		public Vector2Save(Vector4 vector)
		{
			x = 0f;
			y = 0f;
		}

		public Vector2Save(Vector2Save vector)
		{
			x = 0f;
			y = 0f;
		}

		public Vector2Save(Vector3Save vector)
		{
			x = 0f;
			y = 0f;
		}

		public Vector2Save(Vector4Save vector)
		{
			x = 0f;
			y = 0f;
		}

		public static implicit operator Vector2Save(Vector2 vector)
		{
			return default(Vector2Save);
		}

		public static implicit operator Vector2(Vector2Save vector)
		{
			return default(Vector2);
		}

		public static implicit operator Vector2Save(Vector3 vector)
		{
			return default(Vector2Save);
		}

		public static implicit operator Vector3(Vector2Save vector)
		{
			return default(Vector3);
		}

		public static implicit operator Vector2Save(Vector4 vector)
		{
			return default(Vector2Save);
		}

		public static implicit operator Vector4(Vector2Save vector)
		{
			return default(Vector4);
		}

		public static implicit operator Vector2Save(Vector3Save vector)
		{
			return default(Vector2Save);
		}

		public static implicit operator Vector3Save(Vector2Save vector)
		{
			return default(Vector3Save);
		}

		public static implicit operator Vector2Save(Vector4Save vector)
		{
			return default(Vector2Save);
		}

		public static implicit operator Vector4Save(Vector2Save vector)
		{
			return default(Vector4Save);
		}
	}
}
