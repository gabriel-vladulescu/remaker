using System.Collections.Generic;

namespace Ssar.Database
{
	public class FirebaseDictionary
	{
		private Dictionary<string, object> data;

		public FirebaseDictionary(Dictionary<string, object> data)
		{
		}

		public int GetInt(string key)
		{
			return 0;
		}

		public Dictionary<string, object> GetDict(string key)
		{
			return null;
		}

		public List<object> GetList(string key)
		{
			return null;
		}
	}
}
