using System;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.MemoryShard.Command
{
	public class ShowCollectNewShardPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public MemoryShardInfo ShardInfo { get; set; }

		[Inject]
		public Action onFinish { get; set; }

		[Inject]
		public bool isPreload { get; set; }

		[Inject]
		public Action<GameObject> callBack { get; set; }

		public override void Execute()
		{
		}

		protected override string GetAssetPath()
		{
			return null;
		}

		protected override string GetInjectName()
		{
			return null;
		}

		protected override PopupCamera GetCamera()
		{
			return default(PopupCamera);
		}
	}
}
