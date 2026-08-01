using System;

namespace Ssar.Event
{
	public class EventTimeInfo
	{
		public string startTime { get; set; }

		public string endTime { get; set; }

		public DateTime GetStartTime()
		{
			return default(DateTime);
		}

		public DateTime GetEndTime()
		{
			return default(DateTime);
		}
	}
}
