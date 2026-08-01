using System;

namespace Scripts.Config
{
	public abstract class AbsEventInfo
	{
		public abstract string startTime { get; set; }

		public abstract string endTime { get; set; }

		public DateTime GetEndTime()
		{
			return default(DateTime);
		}

		public DateTime GetStartTime()
		{
			return default(DateTime);
		}
	}
}
