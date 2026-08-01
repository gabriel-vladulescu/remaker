using LitJson;

namespace Ssar.Event.EventWar.Model
{
	public class TokenLogData
	{
		[JsonInclude]
		private int maxTokenAdded;

		[JsonInclude]
		private int minTokenAdded;

		public void AddToken(int amount)
		{
		}
	}
}
