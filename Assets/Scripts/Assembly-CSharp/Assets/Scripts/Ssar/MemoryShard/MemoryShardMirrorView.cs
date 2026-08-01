using Scripts.Config;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.MemoryShard
{
	public class MemoryShardMirrorView : View
	{
		public UILabel lb_name;

		public GameObject[] btn_question;

		public GameObject btn_view;

		public GameObject wg_shard;

		public UILabel lb_available;

		private MirrorInfo mirrorInfo;

		private MirrorEffectView effectView;

		private Material material_uncollected;

		private Material material_collected;

		private MemoryShardConfig MemoryShardConfig => null;

		protected override void Awake()
		{
		}

		public void Show(MirrorInfo mirrorInfo)
		{
		}

		public void Hide()
		{
		}

		private void ClearOld()
		{
		}

		private void UpdateVisual()
		{
		}

		private int GetMirrorId()
		{
			return 0;
		}

		private bool IsAvailable()
		{
			return false;
		}

		private void ChecKEnableTextAvailable()
		{
		}

		private bool EnableButtonView()
		{
			return false;
		}

		private void CheckAndEnableButtonQuestion()
		{
		}

		private bool IsUnlocked()
		{
			return false;
		}

		private void RevealShard(MirrorEffectView effectView)
		{
		}

		private void ClickBtnQuestion(GameObject o)
		{
		}

		private void ViewStory(GameObject o)
		{
		}
	}
}
