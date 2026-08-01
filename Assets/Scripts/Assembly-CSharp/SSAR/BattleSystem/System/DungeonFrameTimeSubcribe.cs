using Artemis;
using Assets.Scripts.Core.Scheduling;

namespace SSAR.BattleSystem.System
{
	public class DungeonFrameTimeSubcribe : SimTimeObserver
	{
		private bool enableSimTime;

		private EntityWorld entityWorld;

		public void SubcribeUpdate(EntityWorld entityWorld)
		{
		}

		public void UnSubcribeUpdate()
		{
		}

		public void OnSimTime(uint dt)
		{
		}

		public void SetEnableSimTime(bool enableSimTime)
		{
		}
	}
}
