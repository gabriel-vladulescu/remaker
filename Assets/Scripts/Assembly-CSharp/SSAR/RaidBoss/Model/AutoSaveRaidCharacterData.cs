using Assets.Scripts.Core.Scheduling;
using Scripts.Config;

namespace Ssar.RaidBoss.Model
{
	public class AutoSaveRaidCharacterData : SimTimeObserver
	{
		private bool enabled;

		private float time;

		private float delay;

		private MainCharacterData characterData;

		private readonly GameConfigConstant configConstant;

		public void UpdateCooldown(float cooldown)
		{
		}

		public void Enable(MainCharacterData characterData)
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
