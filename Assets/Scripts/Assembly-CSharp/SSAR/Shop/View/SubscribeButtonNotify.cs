using Assets.Scripts.Ssar.Shop.Model;
using SSAR.View;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class SubscribeButtonNotify : AbsButtonNofity
	{
		private ISubscribePackageLogic iSubscribePackageLogic;

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

		private int Day()
		{
			return 0;
		}
	}
}
