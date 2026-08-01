using SSAR.Equipment.Enum;
using UnityEngine;

namespace Assets.Scripts.Utils
{
	public class WeaponIdOverride : MonoBehaviour
	{
		public int weaponId;

		public Rarity rarity;

		private int counter;

		private int previousWeaponId;

		private int weaponCosmeticId;

		private Rarity previousRarity;

		private Rarity cosmeticWeaponRarity;

		private void Update()
		{
		}
	}
}
