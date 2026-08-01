using System.Collections.Generic;

namespace System
{
	public static class RandomBase
	{
		public delegate float RandomValueFunction();

		public static readonly float RADIAN_MIN;

		public static readonly float RADIAN_MAX;

		public static int Index(RandomValueFunction randomValueFunction, IList<float> rates)
		{
			return 0;
		}

		public static int Sign(RandomValueFunction randomValueFunction)
		{
			return 0;
		}

		public static int Range(RandomValueFunction randomValueFunction, int min, int max)
		{
			return 0;
		}

		public static float Range(RandomValueFunction randomValueFunction, float min, float max)
		{
			return 0f;
		}

		public static void OnUnitCircle(RandomValueFunction randomValueFunction, out float x, out float y)
		{
			x = default(float);
			y = default(float);
		}

		public static void InsideUnitCircle(RandomValueFunction randomValueFunction, out float x, out float y)
		{
			x = default(float);
			y = default(float);
		}

		public static void OnUnitSphere(RandomValueFunction randomValueFunction, out float x, out float y, out float z)
		{
			x = default(float);
			y = default(float);
			z = default(float);
		}

		public static void InsideUnitSphere(RandomValueFunction randomValueFunction, out float x, out float y, out float z)
		{
			x = default(float);
			y = default(float);
			z = default(float);
		}
	}
}
