using Assets.Scripts.Ssar.CharacterSelection.View;
using Scripts.Config;

namespace Ssar.Analytics.Metrics.PlayerProgressions
{
	public class CreateHero
	{
		private CharacterName characterName;

		private int count;

		private readonly CreateCharacterWidget.CharacterCreationSource characterCreationSource;

		public CreateHero(CharacterName characterName, int count, CreateCharacterWidget.CharacterCreationSource characterCreationSource)
		{
		}

		public void Send()
		{
		}
	}
}
