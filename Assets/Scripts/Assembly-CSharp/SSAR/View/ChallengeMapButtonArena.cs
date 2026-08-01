using UnityEngine;

namespace SSAR.View
{
	public class ChallengeMapButtonArena : ChallengeMapButton
	{
		public GameObject wgUnderProcess;

		public UILabel lb_time;

		private float time;

		private float Delay;

		private bool isUnlock;

		private void OnEnable()
		{
		}

		protected override void ShowPopup()
		{
		}

		protected override EffectPathIndex EffectIndex()
		{
			return default(EffectPathIndex);
		}

		protected override bool IsUnlock()
		{
			return false;
		}

		protected override LockType GetLockType()
		{
			return default(LockType);
		}

		protected override int LevelRequireUnlock()
		{
			return 0;
		}

		protected override string MapRequireUnlock()
		{
			return null;
		}

		private void Update()
		{
		}
	}
}
