using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.Environment.Character
{
	public class GameObjectCharacter : Character
	{
		private GameObject gameObject;

		public GameObjectCharacter(GameObject gameObject)
		{
		}

		public Vector3 Position()
		{
			return default(Vector3);
		}

		public bool IsDead()
		{
			return false;
		}
	}
}
