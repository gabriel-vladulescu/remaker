namespace Assets.Scripts.Core.Skills.Conditions
{
	public class CharacterOnGround : Condition
	{
		private Character character;

		public CharacterOnGround(Character character)
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
