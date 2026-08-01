using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.MemoryShard
{
	public class ViewMemoryShardStoryPopup : BasePopup
	{
		public float delayShowWidgetStory;

		public float durationShowWidgetStory;

		public float delayReadStory;

		public float readStoryDuration;

		public float delayCanClose;

		public GameObject wg_shard;

		public GameObject btn_back;

		public UILabel lb_text;

		public TweenPosition tweenPosition;

		public TweenAlpha tweenWidget;

		public GameObject wg_bgFx;

		public UIScrollView ScrollView;

		public UIPanel panel;

		private MirrorEffectView effectView;

		private float time;

		private bool enableCheckTextPosition;

		protected override void Awake()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		public void Show(MirrorInfo info)
		{
		}

		private void ClearOld()
		{
		}

		private void UpdateVisual(MirrorInfo info)
		{
		}

		private void PlayFx()
		{
		}

		private void TweenText(MirrorInfo info)
		{
		}

		private void TweenAlpha()
		{
		}

		private void PlayFxBg()
		{
		}

		private void InitFxBg()
		{
		}

		private void Update()
		{
		}
	}
}
