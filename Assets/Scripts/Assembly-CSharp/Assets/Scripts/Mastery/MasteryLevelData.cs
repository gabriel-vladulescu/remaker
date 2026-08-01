using System;
using CodeStage.AntiCheat.ObscuredTypes;
using LitJson;

namespace Assets.Scripts.Mastery
{
	[Serializable]
	public class MasteryLevelData
	{
		public int masteryId;

		[JsonInclude]
		private ObscuredInt expObscuredInt;

		[JsonInclude]
		private ObscuredInt levelObscuredInt;

		[JsonIgnore]
		public int level
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public int exp
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void AddExp(int exp)
		{
		}

		public void ResetExp()
		{
		}
	}
}
