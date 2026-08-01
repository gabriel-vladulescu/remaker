using System.Collections.Generic;

namespace UnityEngine
{
	public static class RandomEx
	{
		private class RandomExBase : RandomAbstract
		{
			public override float Value()
			{
				return 0f;
			}
		}

		private static readonly RandomExBase Entity;

		static RandomEx()
		{
		}

		public static int Index(IList<float> rates)
		{
			return 0;
		}

		public static int Sign()
		{
			return 0;
		}

		public static int Range(int min, int max)
		{
			return 0;
		}

		public static float Range(float min, float max)
		{
			return 0f;
		}

		public static void OnUnitCircle(out float x, out float y)
		{
			x = default(float);
			y = default(float);
		}

		public static void InsideUnitCircle(out float x, out float y)
		{
			x = default(float);
			y = default(float);
		}

		public static void OnUnitSphere(out float x, out float y, out float z)
		{
			x = default(float);
			y = default(float);
			z = default(float);
		}

		public static void InsideUnitSphere(out float x, out float y, out float z)
		{
			x = default(float);
			y = default(float);
			z = default(float);
		}

		public static Vector2 OnUnitCircle()
		{
			return default(Vector2);
		}

		public static Vector2 InsideUnitCircle()
		{
			return default(Vector2);
		}

		public static Vector3 OnUnitSphere()
		{
			return default(Vector3);
		}

		public static Vector3 InsideUnitSphere()
		{
			return default(Vector3);
		}

		public static Color ColorHSV()
		{
			return default(Color);
		}

		public static Color ColorHSV(float hueMin, float hueMax, float satMin, float satMax, float valMin, float valMax, float alphaMin, float alphaMax)
		{
			return default(Color);
		}
	}
}
