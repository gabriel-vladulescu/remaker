using Scripts.Config;

namespace Ssar.Analytics.Metrics.PlayerProgressions
{
	public interface PlayerProgressionData
	{
		string Version();

		CharacterName CharacterName();

		string LevelString();

		int Level();

		string NodeId();

		int CurrentGold();

		int CurrentCrystal();

		float PlayingTime();

		float RealMoneySpent();

		string NodeValue();

		string HighestNodeValue();

		double Blood();
	}
}
