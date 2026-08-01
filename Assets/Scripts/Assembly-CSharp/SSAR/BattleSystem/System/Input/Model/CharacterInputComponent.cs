using Artemis.Interface;

namespace SSAR.BattleSystem.System.Input.Model
{
	public class CharacterInputComponent : IComponent
	{
		public CharacterInput CharacterInput;

		public CharacterInputComponent(CharacterInput input)
		{
			CharacterInput = input;
		}
	}
}
