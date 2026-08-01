using Scripts.Config;

namespace Ssar.Analytics.Metrics.Social
{
	public interface SocialData
	{
		CharacterName CharacterName();

		int Level();

		string LevelString();

		string HighestNodeId();

		int CurrentGold();

		int CurrentCrystal();

		float PlayingTime();
	}
}
