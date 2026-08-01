namespace Assets.Scripts.Core.UnlockableSystem
{
	public class Entity
	{
		private int id;

		private int[] properties;

		private bool unlocked;

		public int Id => 0;

		public int[] Properties => null;

		public Entity(int id, int[] properties, bool unlocked)
		{
		}

		public bool IsUnlocked()
		{
			return false;
		}

		public void SetUnlocked(bool unlocked)
		{
		}

		public string toString()
		{
			return null;
		}
	}
}
