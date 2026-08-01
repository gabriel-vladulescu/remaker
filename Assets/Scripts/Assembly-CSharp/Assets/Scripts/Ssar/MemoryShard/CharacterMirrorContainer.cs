using System.Collections.Generic;
using Scripts.Config;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.MemoryShard
{
	public class CharacterMirrorContainer : View
	{
		public UILabel lb_characterName;

		public UIScrollView ScrollView;

		public UITable table;

		public UILabel lb_comingsoon;

		private List<MemoryShardMirrorView> memoryShardMirrorViews;

		private bool firstTime;

		private MemoryShardConfig MemoryShardConfig => null;

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void Start()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		private void InitMirror()
		{
		}

		private void UpdateMirror()
		{
		}
	}
}
