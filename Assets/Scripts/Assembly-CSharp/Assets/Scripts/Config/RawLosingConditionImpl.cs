using System.Collections.Generic;
using Scripts.Config;

namespace Assets.Scripts.Config
{
	public class RawLosingConditionImpl : RawLosingCondition
	{
		private LosingCondition lc;

		public RawLosingConditionImpl(LosingCondition lc)
		{
		}

		public string Name()
		{
			return null;
		}

		public IEnumerable<string> Cookies()
		{
			return null;
		}
	}
}
