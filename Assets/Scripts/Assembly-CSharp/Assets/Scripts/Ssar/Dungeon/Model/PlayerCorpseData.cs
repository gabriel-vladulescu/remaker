using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class PlayerCorpseData
	{
		public MainCharacterData MainCharacterData;

		public Vector3 Position { get; set; }

		public PlayerCorpseData(MainCharacterData mainCharacterData, Vector3 position)
		{
		}
	}
}
