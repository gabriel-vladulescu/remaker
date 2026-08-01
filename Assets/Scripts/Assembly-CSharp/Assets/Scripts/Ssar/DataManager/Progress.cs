using System;
using LitJson;

namespace Assets.Scripts.Ssar.DataManager
{
	[Serializable]
	public class Progress
	{
		public int propertyId;

		public int progressValue;

		[JsonIgnore]
		public int PropertyId => 0;

		public Progress()
		{
		}

		public static Progress NotReadyProgress(int propertyId)
		{
			return null;
		}

		private Progress(int propertyId, int progressValue)
		{
		}

		public int GetProgressValue()
		{
			return 0;
		}

		public void SetProgressValue(int value)
		{
		}

		public bool IsReadyToUse()
		{
			return false;
		}
	}
}
