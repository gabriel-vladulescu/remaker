using Assets.Scripts.Ssar.CharacterSelection.Model;
using Assets.Scripts.Ssar.CharacterSelection.View;
using strange.extensions.signal.impl;

namespace Assets.Scripts.Ssar.Signal
{
	public class CreateCharacterSignal : Signal<CharacterCode, string, CreateCharacterWidget.CharacterCreationSource>
	{
	}
}
