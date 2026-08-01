using System;
using Ssar.Rune.Model;

namespace SSAR.Equipment.Model
{
	[Serializable]
	public class RuneSlot
	{
		public bool isEmpty;

		public RuneType runeType;

		public RuneRarity runeRarity;

		public void Equip(RuneType runeType, RuneRarity runeRarity)
		{
		}

		public void Unequip()
		{
		}

		public void Replace(RuneType newType, RuneRarity newRarity)
		{
		}

		public bool IsEmpty()
		{
			return false;
		}

		public RuneType CurrentEquippedRuneType()
		{
			return default(RuneType);
		}

		public RuneRarity CurrentEquippedRuneRarity()
		{
			return default(RuneRarity);
		}
	}
}
