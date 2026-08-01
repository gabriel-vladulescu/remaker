using System;
using UnityEngine;

namespace BayatGames.SaveGameFree.Types
{
	[Serializable]
	public struct QuaternionSave
	{
		public float x;

		public float y;

		public float z;

		public float w;

		public QuaternionSave(float x)
		{
			this.x = 0f;
			y = 0f;
			z = 0f;
			w = 0f;
		}

		public QuaternionSave(float x, float y)
		{
			this.x = 0f;
			this.y = 0f;
			z = 0f;
			w = 0f;
		}

		public QuaternionSave(float x, float y, float z)
		{
			this.x = 0f;
			this.y = 0f;
			this.z = 0f;
			w = 0f;
		}

		public QuaternionSave(float x, float y, float z, float w)
		{
			this.x = 0f;
			this.y = 0f;
			this.z = 0f;
			this.w = 0f;
		}

		public QuaternionSave(Quaternion quaternion)
		{
			x = 0f;
			y = 0f;
			z = 0f;
			w = 0f;
		}

		public static implicit operator QuaternionSave(Quaternion quaternion)
		{
			return default(QuaternionSave);
		}

		public static implicit operator Quaternion(QuaternionSave quaternion)
		{
			return default(Quaternion);
		}
	}
}
