namespace Assets.Scripts.Core.Skills.Conditions
{
	public class CharacterInTheAir : Condition
	{
		private Character character;

		public CharacterInTheAir(Character character)
		{
		}

		public bool IsMeet()
		{
			return false;
		}

		public void Update(float dt)
		{
		}

		public string Reason()
		{
			return null;
		}
	}
}
