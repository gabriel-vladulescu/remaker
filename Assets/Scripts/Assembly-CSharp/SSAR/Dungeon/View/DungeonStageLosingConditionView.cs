using Assets.Scripts.Ssar.Dungeon.Configs;
using strange.extensions.mediation.impl;

namespace SSAR.Dungeon.View
{
	public class DungeonStageLosingConditionView : strange.extensions.mediation.impl.View
	{
		public UIWidget container;

		public UILabel lb_time;

		public UIPlayTween PlayTween;

		public UILabel lb_timeInTween;

		public TweenPosition tweenPosition;

		public UIWidget start;

		public UIWidget end;

		private float time;

		protected override void Awake()
		{
		}

		public void Anchor(UIWidget target)
		{
		}

		public void OnEnterStage(int stageOrder)
		{
		}

		public void OnClearStage(int stageOrder)
		{
		}

		private void EnterStage(Stage stage)
		{
		}

		private void PlayEffectTime(int time)
		{
		}

		private void OnDungeonUpdate(float deltaTime)
		{
		}

		private string FormatTime(float time)
		{
			return null;
		}
	}
}
