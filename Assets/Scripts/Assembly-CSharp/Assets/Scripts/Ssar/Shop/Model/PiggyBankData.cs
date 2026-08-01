using System;
using LitJson;

namespace Assets.Scripts.Ssar.Shop.Model
{
	[Serializable]
	public class PiggyBankData
	{
		[JsonInclude]
		private int soulSaved;

		[JsonInclude]
		private bool hasInit;

		[JsonInclude]
		private int purchasedCount;

		private int mValue;

		[JsonInclude]
		private int savedValue
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void SaveValue(int soul)
		{
		}

		public int GetSavedValue()
		{
			return 0;
		}

		public bool HasInit()
		{
			return false;
		}

		public void SetInited()
		{
		}

		public void Bought(int sountInit)
		{
		}

		public int GetPurchasedCount()
		{
			return 0;
		}
	}
}
