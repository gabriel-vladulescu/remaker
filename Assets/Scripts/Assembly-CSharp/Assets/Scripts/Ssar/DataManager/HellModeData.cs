using System;
using System.Collections.Generic;
using LitJson;

namespace Assets.Scripts.Ssar.DataManager
{
	[Serializable]
	public class HellModeData
	{
		[JsonInclude]
		private int id;

		[JsonInclude]
		private List<DeathLocation> deathLocations;

		[JsonInclude]
		private DeathLocation lastestRemovedLocation;

		public DeathLocation AddDeathLocation(int dungeonId, float x, int soul)
		{
			return null;
		}

		public IEnumerable<DeathLocation> ShowDeathLocations()
		{
			return null;
		}

		public List<DeathLocation> FindDeathLocationsOfDungeon(int dungeonId)
		{
			return null;
		}

		public bool RemoveDeathLocation(int id)
		{
			return false;
		}

		public bool RemoveOldestDeathLocation()
		{
			return false;
		}

		public DeathLocation GetOldestDeathLocation()
		{
			return null;
		}

		public int GetNumberOfDeathLocations()
		{
			return 0;
		}

		public DeathLocation GetLastestRemovedLocation()
		{
			return null;
		}

		public void ClearLastestRemovedLocation()
		{
		}
	}
}
