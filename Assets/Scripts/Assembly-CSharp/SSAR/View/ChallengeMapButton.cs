using UnityEngine;

namespace SSAR.View
{
	public abstract class ChallengeMapButton : MonoBehaviour
	{
		public enum LockType
		{
			Level = 0,
			Map = 1
		}

		public enum Mode
		{
			Tower = 0,
			Arena = 1,
			Raid = 2,
			DailyChallenge = 3
		}

		public Color32 colorUnlock;

		public Color32 colorLock;

		public GameObject btnClick;

		public GameObject wg_active;

		public GameObject wg_lock;

		public bool disableFx;

		private GameObject fx;

		private void Awake()
		{
		}

		public virtual void Check()
		{
		}

		private void Fx()
		{
		}

		private void ClickObject(GameObject o)
		{
		}

		protected abstract void ShowPopup();

		protected abstract EffectPathIndex EffectIndex();

		protected abstract bool IsUnlock();

		protected abstract LockType GetLockType();

		protected abstract int LevelRequireUnlock();

		protected abstract string MapRequireUnlock();

		private void CheckUnLock()
		{
		}

		private string GetUnlockRequirementDesc(bool shorted = false)
		{
			return null;
		}
	}
}
