using System.Collections.Generic;

namespace System
{
	public abstract class RandomAbstract
	{
		protected readonly RandomBase.RandomValueFunction randomValueFunction;

		public RandomAbstract()
		{
		}

		public abstract float Value();

		public int Index(IList<float> rates)
		{
			return 0;
		}

		public int Sign()
		{
			return 0;
		}

		public int Range(int min, int max)
		{
			return 0;
		}

		public float Range(float min, float max)
		{
			return 0f;
		}

		public void OnUnitCircle(out float x, out float y)
		{
			x = default(float);
			y = default(float);
		}

		public void InsideUnitCircle(out float x, out float y)
		{
			x = default(float);
			y = default(float);
		}

		public void OnUnitSphere(out float x, out float y, out float z)
		{
			x = default(float);
			y = default(float);
			z = default(float);
		}

		public void InsideUnitSphere(out float x, out float y, out float z)
		{
			x = default(float);
			y = default(float);
			z = default(float);
		}
	}
}
