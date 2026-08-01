using System;

namespace Assets.Scripts.Ssar.DataManager
{
	[Serializable]
	public class DeathLocation
	{
		public int id;

		public int dungeonId;

		public float x;

		public int soul;

		public int Id => 0;

		public int DungeonId => 0;

		public float X => 0f;

		public int Soul => 0;

		public DeathLocation()
		{
		}

		public DeathLocation(int id, int dungeonId, float x, int soul)
		{
		}
	}
}
