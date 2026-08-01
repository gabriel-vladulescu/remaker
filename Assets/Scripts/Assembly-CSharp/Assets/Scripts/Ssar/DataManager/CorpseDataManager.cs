using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Corpse.Logic;
using Assets.Scripts.Ssar.Dungeon.Corpse.Model;
using Firebase.Database;
using Scripts.Config;

namespace Assets.Scripts.Ssar.DataManager
{
	public class CorpseDataManager
	{
		private Dictionary<string, CorpseModel> corpse;

		private CorpsePool corpsePool;

		public void RequestCorpse(ConfigManager configManager, int nodeId)
		{
		}

		public void RequestCorpseExactly(ConfigManager configManager, int nodeId)
		{
		}

		public CorpseModel GetCorpseModel(int nodeId, ConfigManager configManager)
		{
			return null;
		}

		public void RefreshCorpseOfNode(ConfigManager configManager, int nodeId)
		{
		}

		private void AddCorpseModel(CorpseModel model, ConfigManager configManager)
		{
		}

		public void Recognize(MainCharacterData mainCharacterData, int nodeId, int posX)
		{
		}

		private CorpsePool GetCorpsePool()
		{
			return null;
		}

		private bool Available()
		{
			return false;
		}

		private FirebaseDatabase GetFirebaseDatabase()
		{
			return null;
		}

		private string NodeIdToKey(int nodeId, ConfigManager configManager)
		{
			return null;
		}
	}
}
