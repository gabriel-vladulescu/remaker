using System.Collections.Generic;
using SSAR.View;
using Scripts.Config;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class ButtonLevelUpNotify : AbsButtonNofity
	{
		private MainCharacterData mainCharacterData;

		private ConfigManager configManager;

		private int level;

		private GameObject fx;

		protected override void Awake()
		{
		}

		protected override bool IsNotify()
		{
			return false;
		}

		private bool Method1()
		{
			return false;
		}

		private bool Method2()
		{
			return false;
		}

		private bool IsContain(int productId, List<NewLevelUpPackageProductInfo> newLevelUpPackageProductInfos)
		{
			return false;
		}
	}
}
