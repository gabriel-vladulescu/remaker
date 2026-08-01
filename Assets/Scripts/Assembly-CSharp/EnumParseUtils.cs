using System;
using System.Collections.Generic;

public static class EnumParseUtils
{
	private class Ret
	{
		public bool success;

		public object value;

		public Ret(bool success, object value)
		{
		}
	}

	private static Dictionary<string, Ret> cache;

	public static bool Parse<T>(string text, T defaultValue, out T ret) where T : struct, IComparable, IFormattable, IConvertible
	{
		ret = default(T);
		return false;
	}

	public static T Parse<T>(string text, T defaultValue) where T : struct, IComparable, IFormattable, IConvertible
	{
		return default(T);
	}
}
