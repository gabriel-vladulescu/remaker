namespace Ssar.Analytics.Metrics
{
	public interface Target
	{
		void Receive(string eventName, CustomEventData ced);
	}
}
