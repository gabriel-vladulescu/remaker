using System;
using System.Collections.Generic;
using UnityEngine;

namespace SSAR.Dungeon.HUD
{
	[Serializable]
	[CreateAssetMenu(menuName = "ScriptableOject/HUD")]
	public class HUDConfig : ScriptableObject
	{
		public HUDTextInfo[] sets;

		[SerializeField]
		public List<FlashInfo> setFlash;

		public HUDTextInfo GetHUDTextInfo(HUDTextType type)
		{
			return null;
		}

		public FlashInfo GetFlashInfoByType(FlashType type)
		{
			return null;
		}

		public void AddNewFlashInfo(FlashType damageType)
		{
		}

		public void AddNewHUDTextInfo(HUDTextType type, HUDTextGroupType group)
		{
		}

		private bool HasType(HUDTextType type)
		{
			return false;
		}
	}
}
