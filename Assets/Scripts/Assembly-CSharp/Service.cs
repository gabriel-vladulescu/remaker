using System;
using System.Collections.Generic;

public static class Service
{
	[ThreadStatic]
	private static List<IServiceWrapper> serviceWrapperList;

	public static void Set<T>(T instance)
	{
	}

	public static T Get<T>()
	{
		return default(T);
	}

	public static bool IsSet<T>()
	{
		return false;
	}

	public static void ResetAll()
	{
	}

	public static void Unset<T>()
	{
	}
}
