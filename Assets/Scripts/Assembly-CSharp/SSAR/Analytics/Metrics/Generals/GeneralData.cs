using Scripts.Config;

namespace Ssar.Analytics.Metrics.Generals
{
	public interface GeneralData
	{
		string Version();

		CharacterName CharacterName();

		string Level();

		float PlayingTime();
	}
}
