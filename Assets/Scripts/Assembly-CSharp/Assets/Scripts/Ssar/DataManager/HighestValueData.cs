using System;
using System.Collections.Generic;

namespace Assets.Scripts.Ssar.DataManager
{
	[Serializable]
	public class HighestValueData
	{
		public Dictionary<string, double> highestValues;

		public void PutValue(ValueName name, double value)
		{
		}

		public float GetValue(ValueName name)
		{
			return 0f;
		}

		public HighestValueData Clone()
		{
			return null;
		}
	}
}
