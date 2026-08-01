using Assets.Scripts.Core.Scheduling;

namespace SSAR.Entry.Model
{
	public class AutoSaveCloudManager : SimTimeObserver
	{
		private float DELAY_AUTO_SAVE;

		private float DELAY_SAVE_WITH_LOCAL;

		private float saveWithLocal;

		private float delaySave;

		private LoginDataManager loginDataManager;

		public AutoSaveCloudManager(LoginDataManager loginDataManager)
		{
		}

		public void OnSaveLocal(bool forceSaveToCloud)
		{
		}

		public void UpdateTimeDelaySave(double delayAutoSave, double delaySaveToServer)
		{
		}

		public void OnSimTime(uint dt)
		{
		}

		private void Save()
		{
		}
	}
}
