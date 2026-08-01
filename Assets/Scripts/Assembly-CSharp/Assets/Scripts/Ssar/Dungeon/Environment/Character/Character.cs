using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.Environment.Character
{
	public interface Character
	{
		Vector3 Position();

		bool IsDead();
	}
}
