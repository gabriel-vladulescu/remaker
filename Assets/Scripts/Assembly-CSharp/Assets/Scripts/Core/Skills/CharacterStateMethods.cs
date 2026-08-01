namespace Assets.Scripts.Core.Skills
{
	internal static class CharacterStateMethods
	{
		private static Character.CharacterState[] INPUT_BLOCKED;

		private static Character.CharacterState[] INPUT_ALLOWED;

		static CharacterStateMethods()
		{
		}

		public static int Rank(this Character.CharacterState characterState)
		{
			return 0;
		}

		public static Character.CharacterState From(this Character.CharacterState ctor, int rank)
		{
			return default(Character.CharacterState);
		}

		public static bool IsInputBlocked(this Character.CharacterState characterState)
		{
			return false;
		}
	}
}
