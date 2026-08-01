using System;

namespace UnityEngine
{
	public abstract class RandomAbstract : System.RandomAbstract
	{
		public Vector2 OnUnitCircle()
		{
			return default(Vector2);
		}

		public Vector2 InsideUnitCircle()
		{
			return default(Vector2);
		}

		public Vector3 OnUnitSphere()
		{
			return default(Vector3);
		}

		public Vector3 InsideUnitSphere()
		{
			return default(Vector3);
		}

		public Color ColorHSV()
		{
			return default(Color);
		}

		public Color ColorHSV(float hueMin, float hueMax, float satMin, float satMax, float valMin, float valMax, float alphaMin, float alphaMax)
		{
			return default(Color);
		}
	}
}
