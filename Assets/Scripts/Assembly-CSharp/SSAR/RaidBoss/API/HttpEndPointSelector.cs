using System.Collections.Generic;

namespace Ssar.RaidBoss.API
{
	public class HttpEndPointSelector
	{
		public enum Name
		{
			Local = 0,
			ConfigConstant = 1
		}

		private Dictionary<Name, HttpEndPoints> config;

		public bool Select(Name httpEndPointName, ref HttpEndPoints endPoints)
		{
			return false;
		}
	}
}
