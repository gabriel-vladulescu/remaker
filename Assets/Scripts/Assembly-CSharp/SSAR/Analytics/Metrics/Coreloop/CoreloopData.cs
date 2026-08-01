using Scripts.Config;

namespace Ssar.Analytics.Metrics.Coreloop
{
	public interface CoreloopData
	{
		string Version();

		CharacterName CharacterName();

		string LevelString();

		int Level();

		string HighestNodeId();

		string HighestNodeValue();

		int CurrentGold();

		int CurrentCrystal();

		int PlayingTime();

		string HighestRankId();

		string CurrentWeapon();

		string CurrentArmor();

		string CurrentAccessory();

		string CurrentCostume();

		string CurrentAncient();
	}
}
