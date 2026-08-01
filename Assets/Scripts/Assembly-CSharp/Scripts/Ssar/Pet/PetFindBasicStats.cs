using Assets.Scripts.Ssar.Dungeon.Model;
using Scripts.Config;

namespace Scripts.Ssar.Pet
{
	public class PetFindBasicStats : IFindBasicStats
	{
		private readonly ConfigManager configManager;

		private readonly int groupId;

		private readonly int subId;

		public PetFindBasicStats(ConfigManager configManager, int groupId, int subId)
		{
		}

		public HeroBasicStats HeroBasicStats()
		{
			return null;
		}
	}
}
