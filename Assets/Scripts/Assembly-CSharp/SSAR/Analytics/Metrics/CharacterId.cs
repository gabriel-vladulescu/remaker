using Assets.Scripts.Config;

namespace Ssar.Analytics.Metrics
{
	public class CharacterId : MonsterId
	{
		public CharacterId(string rawValue)
			: base(null)
		{
		}

		public CharacterId(int groupId, int subId, int level)
			: base(null)
		{
		}
	}
}
