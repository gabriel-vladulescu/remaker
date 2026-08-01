using UnityEngine;

namespace Ssar.Main.View
{
	public abstract class MainSceneButton : MonoBehaviour
	{
		public enum LockType
		{
			Level = 0,
			Map = 1
		}

		public Color32 colorUnlock;

		public Color32 colorLock;

		public GameObject btnClick;

		public GameObject wg_active;

		public GameObject wg_lock;

		private void Awake()
		{
		}

		public virtual void Check()
		{
		}

		private void ClickObject(GameObject o)
		{
		}

		protected abstract void ShowPopup();

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
