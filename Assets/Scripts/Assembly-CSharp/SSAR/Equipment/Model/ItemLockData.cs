using System;
using System.Collections.Generic;

namespace SSAR.Equipment.Model
{
	[Serializable]
	public class ItemLockData
	{
		public List<int> listCollectId;

		public List<int> petCollectId;

		public void LockIEquipment(int collectId)
		{
		}

		public void UnlockEquipment(int collectId)
		{
		}

		public bool IsLocked(int collectId)
		{
			return false;
		}

		public void LockPet(int collectId)
		{
		}

		public void UnlockPet(int collectId)
		{
		}

		public bool IsLockedPet(int collectId)
		{
			return false;
		}
	}
}
