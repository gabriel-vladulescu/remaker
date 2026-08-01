using System;
using Assets.Scripts.Ssar.Dungeon.Corpse.Model;
using Firebase.Database;

namespace Assets.Scripts.Ssar.Dungeon.Corpse.Logic
{
	public class CorpsePool
	{
		private float successRate;

		private readonly int minCorpsePerNode;

		private FirebaseDatabase database;

		public CorpsePool(float successRate, int minCorpsePerNode, FirebaseDatabase database)
		{
		}

		public void Obtain(int nodeId, Action<bool, int, CorpseModel> callback)
		{
		}

		private void OnCorpseListAvailable(int nodeId, Action<bool, int, CorpseModel> callback, DataSnapshot dataSnapshot)
		{
		}

		private void RemoveCorpse(int nodeId, string pathToSelectedCorpse, string selectedCorpseId)
		{
		}

		private void CountCorpses(int nodeId, Action<bool, int> callback)
		{
		}
	}
}
