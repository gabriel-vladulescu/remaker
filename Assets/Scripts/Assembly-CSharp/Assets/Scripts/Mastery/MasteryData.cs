using System;
using System.Collections.Generic;
using LitJson;

namespace Assets.Scripts.Mastery
{
	[Serializable]
	public class MasteryData
	{
		[JsonInclude]
		private List<MasteryLevelData> masteryLevelDatas;

		public MasteryLevelData GetMasteryLevelData(int masteryId)
		{
			return null;
		}

		private int Comparer(MasteryLevelData a, MasteryLevelData b)
		{
			return 0;
		}
	}
}
