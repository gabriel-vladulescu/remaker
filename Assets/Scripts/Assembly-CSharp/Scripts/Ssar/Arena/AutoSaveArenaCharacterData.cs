using Assets.Scripts.Core.Scheduling;

namespace Scripts.Ssar.Arena
{
	public class AutoSaveArenaCharacterData : SimTimeObserver
	{
		private bool enble;

		private float time;

		private float delay;

		private MainCharacterData mainCharacterData;

		public void UpdateCooldown(float cooldown)
		{
		}

		public void Enable(MainCharacterData mainCharacterData)
		{
		}

		public void OnSimTime(uint dt)
		{
		}

		private void SendCheckEligible()
		{
		}
	}
}
