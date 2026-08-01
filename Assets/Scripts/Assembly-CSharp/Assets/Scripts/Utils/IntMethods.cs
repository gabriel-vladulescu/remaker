using CodeStage.AntiCheat.ObscuredTypes;

namespace Assets.Scripts.Utils
{
	public static class IntMethods
	{
		public static bool IsSumOverflowWith(this int number1, int number2)
		{
			return false;
		}

		public static bool IsSumOverflowWith(this ObscuredInt number1, ObscuredInt number2)
		{
			return false;
		}
	}
}
