using System.Collections.Generic;
using System.ComponentModel;

namespace Ssar.Database
{
	public static class ObjectToDictionaryHelper
	{
		public static void RenameKey<TKey, TValue>(this IDictionary<TKey, TValue> dic, TKey fromKey, TKey toKey)
		{
		}

		public static IDictionary<string, object> ToDictionary(this object source)
		{
			return null;
		}

		public static IDictionary<string, T> ToDictionary<T>(this object source)
		{
			return null;
		}

		private static void AddPropertyToDictionary<T>(PropertyDescriptor property, object source, Dictionary<string, T> dictionary)
		{
		}

		private static bool IsOfType<T>(object value)
		{
			return false;
		}

		private static void ThrowExceptionWhenSourceArgumentIsNull()
		{
		}
	}
}
