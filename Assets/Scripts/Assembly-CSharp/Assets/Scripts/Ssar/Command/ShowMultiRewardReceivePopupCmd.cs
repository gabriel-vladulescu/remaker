using System;
using System.Collections.Generic;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class ShowMultiRewardReceivePopupCmd : strange.extensions.command.impl.Command
	{
		private Queue<ItemInfo> queue;

		[Inject]
		public List<ItemInfo> ItemInfos { get; set; }

		[Inject]
		public Action onFinish { get; set; }

		public override void Execute()
		{
		}

		private void Notify()
		{
		}
	}
}
