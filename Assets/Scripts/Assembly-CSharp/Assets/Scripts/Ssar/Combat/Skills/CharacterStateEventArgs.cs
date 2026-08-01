using System;
using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class CharacterStateEventArgs : EventArgs
	{
		private Character.CharacterState newState;

		public Character.CharacterState NewState => default(Character.CharacterState);

		public CharacterStateEventArgs(Character.CharacterState newState)
		{
		}
	}
}
