using System;
using LitJson;

namespace Assets.Scripts.Ssar.DataManager
{
	[Serializable]
	public class FreeEquipmentData
	{
		[JsonInclude]
		private int firstAdsLastTimeClaim;

		[JsonInclude]
		private int secondAdsLastTimeClaim;

		[JsonInclude]
		private int thirdAdsLastTimeClaim;

		[JsonInclude]
		private int weaponLastTimeClaim;

		[JsonInclude]
		private int armorLastTimeClaim;

		[JsonInclude]
		private int accessoryLastTimeClaim;

		[JsonIgnore]
		public int FirstAdsLastTimeClaim => 0;

		[JsonIgnore]
		public int SecondAdsLastTimeClaim => 0;

		[JsonIgnore]
		public int ThirdAdsLastTimeClaim => 0;

		[JsonIgnore]
		public int WeaponLastTimeClaim => 0;

		[JsonIgnore]
		public int ArmorLastTimeClaim => 0;

		[JsonIgnore]
		public int AccessoryLastTimeClaim => 0;

		public void ClaimFirstAds()
		{
		}

		public void ClaimSecondAds()
		{
		}

		public void ClaimThirdAds()
		{
		}

		public void ClaimWeapon()
		{
		}

		public void ClaimArmor()
		{
		}

		public void ClaimAccessory()
		{
		}
	}
}
