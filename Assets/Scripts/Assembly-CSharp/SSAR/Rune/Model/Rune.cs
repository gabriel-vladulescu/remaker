using System;
using CodeStage.AntiCheat.ObscuredTypes;
using LitJson;
using SSAR.Entry.Model;
using SSAR.Equipment.Enum;

namespace Ssar.Rune.Model
{
	[Serializable]
	public class Rune : ICollectData
	{
		public int collectId;

		public RuneType type;

		public RuneRarity rarity;

		public RuneLogData RuneLogData;

		[JsonInclude]
		private ObscuredInt mCount;

		public int count
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
		public int collectID
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
		public CollectType collectType
		{
			get
			{
				return default(CollectType);
			}
			set
			{
			}
		}

		[JsonIgnore]
		public int Count => 0;

		[JsonIgnore]
		public RuneType Type => default(RuneType);

		[JsonIgnore]
		public RuneRarity Rarity => default(RuneRarity);

		public Rune()
		{
		}

		public Rune(int collectId, int count, RuneType type, RuneRarity rarity)
		{
		}

		public bool IncreaseBy(int number, RewardReason rewardReason)
		{
			return false;
		}

		public bool DecreaseBy(int number, ConsumeRuneReason reason)
		{
			return false;
		}

		public bool IsIncreasableBy(int number)
		{
			return false;
		}

		public bool IsDecreasableBy(int number)
		{
			return false;
		}
	}
}
