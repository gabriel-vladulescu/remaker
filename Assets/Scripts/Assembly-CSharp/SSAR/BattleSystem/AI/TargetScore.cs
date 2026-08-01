using System;

namespace SSAR.BattleSystem.AI
{
	[Serializable]
	public class TargetScore : ICloneable
	{
		public EntityGroupType group;

		public EntityTagType tag;

		public int value;

		public float applyScoreRange;

		public object Clone()
		{
			return null;
		}
	}
}
