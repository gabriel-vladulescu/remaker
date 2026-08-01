using System;

namespace Scripts.Config.Remote
{
	public interface ServerStatus
	{
		void Read(Action<bool, ServerStatusValue> resultCallback);
	}
}
