using System.Collections.Generic;
using Ssar.Rune.Model;

namespace Scripts.Config
{
	public class RandomRuneConfig : IConfig
	{
		public class RandomRune
		{
			public int id;

			public string[] types;

			public string[] rarities;

			private TypeRate[] typeRates;

			private RarityRate[] rarityRates;

			public TypeRate[] TypeRates => null;

			public RarityRate[] RarityRates => null;

			public void Parse()
			{
			}
		}

		public class RarityRate
		{
			private RuneRarity runeRarity;

			private double rate;

			public RuneRarity RuneRarity => default(RuneRarity);

			public double Rate => 0.0;

			public RarityRate(RuneRarity runeRarity, double rate)
			{
			}

			public RarityRate(string raw)
			{
			}
		}

		public class TypeRate
		{
			private RuneType runeType;

			private double rate;

			public RuneType RuneType => default(RuneType);

			public double Rate => 0.0;

			public TypeRate(RuneType runeType, double rate)
			{
			}

			public TypeRate(string raw)
			{
			}
		}

		public Dictionary<string, RandomRune> runes;

		public void OnMapValue(string content)
		{
		}

		public bool FindRandomRune(string id, ref RandomRune randomRune)
		{
			return false;
		}
	}
}
